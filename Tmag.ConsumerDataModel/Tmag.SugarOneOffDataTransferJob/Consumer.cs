using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Tmag.SugarOneOffDataTransferJob.Models;

namespace Tmag.SugarOneOffDataTransferJob
{
    public class Consumer
    {
        private readonly IRepository _repository;
        private readonly SugarDataContext _sugarDataContext;
        private readonly ILogger<Consumer> _logger;
        private readonly StaticTableHelper _staticTableHelper;
        private readonly int _splitCount = 30;
        private  int _startCount = 0;

        public Consumer(IRepository repository, SugarDataContext sugarDataContext,
            ILogger<Consumer> logger, StaticTableHelper staticTableHelper, IOptions<LoadSettings> settings)
        {
            _repository = repository;
            _sugarDataContext = sugarDataContext;
            _logger = logger;
            _staticTableHelper = staticTableHelper;
            _startCount = settings.Value.StartCount;
        }
        private List<string> emailsSaved = new List<string>();
        public void Migrate()
        {
            try
            {
                _logger.LogInformation("################# Migration of Consumers");
                _sugarDataContext.Database.SetCommandTimeout(600);

                var idsOld = _repository.Query<MfeUserIds>().Select(x => x.Id).ToList();
                var consumersFromSugar = _sugarDataContext.Query<CConsumers>().OrderByDescending(x => x.DateModified)
                    .Where(x => idsOld.Contains(x.Id)).AsNoTracking().ToList();
                var sugarGolferProfileAll = _sugarDataContext.Query<CConsumersCstm>()
                    .Where(x => idsOld.Contains(x.IdC)).AsNoTracking().ToList();
                var countFromSugar = consumersFromSugar.Count();

                var loopCount = countFromSugar / _splitCount;

                _logger.LogInformation("#################Starting Migration of Consumers");
                _logger.LogInformation($"Found {countFromSugar} to migrate");
                var systemId = getSystemId();
                var regionId = _repository.Query<Region>().FirstOrDefault(y => y.Code == "USA").Id.Value;
                for (var x = 0; x < loopCount; x++)
                {
                    var skip = _startCount + (x * _splitCount);
                    if (skip > countFromSugar) break;
                    _logger.LogInformation($"Starting segment starting at {skip}");

                    _repository.ReloadContext();
                    _repository.GetDatabase().ChangeTracker.AutoDetectChangesEnabled = false;
                    var sugarItems = consumersFromSugar.Skip(skip).Take(_splitCount).ToList();

                    foreach (var sItem in sugarItems)
                    {
                        if (string.IsNullOrWhiteSpace(sItem.Email)) continue;
                        

                        var exists = _repository.Query<ConsumerData.Models.Consumer>().Any(y => y.PrimaryEmail.ToLower().Trim() == sItem.Email.ToLower().Trim());

                        if (exists)
                            continue;

                        emailsSaved.Add(sItem.Email);

                        var cdmItem = new ConsumerData.Models.Consumer();
                        cdmItem.FirstName = sItem.Fname;
                        cdmItem.LastName = sItem.Lname;
                        cdmItem.PrimaryEmail = sItem.Email;
                        cdmItem.Created = sItem.DateEntered ?? DateTime.UtcNow;
                        cdmItem.Modified = sItem.DateModified ?? DateTime.UtcNow;
                        cdmItem.Dob = sItem.Dob;
                        cdmItem.Gender = sItem.Gender;
                        try
                        {
                            var consumerProfile = new ConsumerProfile
                            {
                                RegionId = regionId,
                                PhoneHome = sItem.Phonehm,
                                PhoneCell = sItem.Phonemb,
                                Notes = sItem.Description,
                                Created = sItem.DateEntered ?? DateTime.UtcNow
                            }; 

                            if (sItem.AddressPostalcode != null)
                            {
                                consumerProfile.Address = new Address
                                {
                                    Created = sItem.DateEntered ?? DateTime.UtcNow,
                                    AddressLine1 = sItem.AddressStreet,
                                    City = sItem.AddressCity,
                                    State = sItem.AddressState,
                                    Country = sItem.AddressCountry ?? "USA",
                                    ZipCode = sItem.AddressPostalcode,
                                    SystemId = systemId
                                };
                            }
                            if (consumerProfile.SystemToConsumerProfiles == null)
                                consumerProfile.SystemToConsumerProfiles = new List<SystemToConsumerProfile>();

                            if (consumerProfile.SystemToConsumerProfiles.All(y => y.SystemId != systemId))
                                consumerProfile.SystemToConsumerProfiles.Add(new SystemToConsumerProfile() { SystemId = systemId, Created = DateTime.UtcNow });

                            consumerProfile.ConsumerExperiences = new List<ConsumerExperience>();

                            cdmItem.ConsumerProfiles = new List<ConsumerProfile>() { consumerProfile };
                        }
                        catch (Exception e)
                        {
                            _logger.LogError($"broke in comsumer profile create ");

                            if (e.Message != null)
                                _logger.LogError(e.Message);
                            _logger.LogError(e.StackTrace);
                            if (e.InnerException != null && e.InnerException.Message != null)
                                _logger.LogError(e.InnerException.Message);
                        }
                        try
                        {
                            var sugarGolferProfile = sugarGolferProfileAll.FirstOrDefault(y => y.IdC == sItem.Id);

                            if (sugarGolferProfile != null)
                            {
                                var golferProfile = new GolferProfile();
                                if (!string.IsNullOrEmpty(sugarGolferProfile.HandicapC))
                                {
                                    int handicap = 0;

                                    var wasNumber = int.TryParse(sugarGolferProfile.HandicapC, out handicap);

                                    if(wasNumber)
                                        golferProfile.Handicap =  handicap;
                                }
                                if (!string.IsNullOrEmpty(sugarGolferProfile.DriverLoftC))
                                    golferProfile.DriverLoftId = _staticTableHelper.GetLoftId(sugarGolferProfile.DriverLoftC);
                                if (!string.IsNullOrEmpty(sugarGolferProfile.DriverShaftFlexC))
                                    golferProfile.CurrentDriverFlexId = _staticTableHelper.GetFlexId(sugarGolferProfile.DriverShaftFlexC);
                                golferProfile.CurrentDriverBallFlight = sugarGolferProfile.CurrentDriverBallFlightC;
                                golferProfile.DesiredDriverBallFlight = sugarGolferProfile.DesiredDriverBallFlightC;
                                golferProfile.TypicalDriverDistance = sugarGolferProfile.TypicalDriverDistanceC;
                                if (!string.IsNullOrEmpty(sugarGolferProfile.IronLengthC))
                                    golferProfile.CurrentIronLengthId = _staticTableHelper.GetChaftLengthId(sugarGolferProfile.IronLengthC);
                                golferProfile.Current7IronBallFlight = sugarGolferProfile.CurrentIronBallFlightC;
                                if (!string.IsNullOrEmpty(sugarGolferProfile.IronLieC))
                                    golferProfile.CurrentIronLieId = _staticTableHelper.GetLieId(sugarGolferProfile.IronLieC);
                                golferProfile.Desired7IronBallFlight = sugarGolferProfile.DesiredIronBallFlightC;
                                golferProfile.Typical7IronDistance = sugarGolferProfile.TypicalIronDistanceC;
                                golferProfile.Created = DateTime.UtcNow;
                                int rpms = 0;
                                int.TryParse(sItem.Rpm, out rpms);
                                golferProfile.RoundsPerMonth = rpms;


                                if (!string.IsNullOrEmpty(sItem.Dexterity))
                                    golferProfile.ClubHandId = _staticTableHelper.GetClubHandId(sItem.Dexterity);
                                cdmItem.GolferProfile = golferProfile;
                            }
                        }
                        catch (Exception e)
                        {
                            _logger.LogError($"broke on golfer profile create ");

                            if (e.Message != null)
                                _logger.LogError(e.Message);
                            _logger.LogError(e.StackTrace);
                            if (e.InnerException != null && e.InnerException.Message != null)
                                _logger.LogError(e.InnerException.Message);
                        }

                        try
                        {
                            _repository.SaveQueue(cdmItem);
                        }
                        catch (Exception e)
                        {
                            _logger.LogError($"failed to save ");
                            if (e.Message != null)
                                _logger.LogError(e.Message);
                            _logger.LogError(e.StackTrace);
                            if (e.InnerException != null && e.InnerException.Message != null)
                                _logger.LogError(e.InnerException.Message);
                        }                      
                    }


                    _logger.LogError($"Saving Consumers ");
                    try
                    {
                        _repository.Save();

                    }
                    catch (Exception e)
                    {
                        _logger.LogError($"failed to save ");
                        if (e.Message != null)
                            _logger.LogError(e.Message);
                        _logger.LogError(e.StackTrace);
                        if (e.InnerException != null && e.InnerException.Message != null)
                            _logger.LogError(e.InnerException.Message);
                    }
                    _logger.LogError($"Saving Consumer");
                }

            }
            catch (Exception e)
            {
                _logger.LogError("failed", e);

                if (e.Message != null)
                    _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
                if (e.InnerException != null && e.InnerException.Message != null)
                    _logger.LogError(e.StackTrace);
            }
        }

        private int? GetHandicapFromRange(string handicapC)
        {
            var split = handicapC.Replace(" ", "").Split("to");
            if (split.Length > 1)
            {
                int first;
                int second;
                var tF = int.TryParse(split[0], out first);

                var tS = int.TryParse(split[0], out second);

                if (tF && tS)
                {
                    return (first + second) / 2;
                }
                else if (tF)
                {
                    return first;
                }
                else if (tS)
                {
                    return second;
                }
            }
            else
            {
                int first;
                var tF = int.TryParse(split[0], out first);
                if (tF)
                {
                    return first;
                }
            }
            return null;
        }

        private Guid getSystemId()
        {
            var system = _repository.Query<ConsumerData.Models.System>().FirstOrDefault(x => x.name == "Sugar");
            if (system == null)
            {
                system = new ConsumerData.Models.System()
                {
                    name = "Sugar",
                    Created = DateTime.UtcNow
                };
                _repository.Save(system);
            }
            return system.Id.Value;
        }
    }
}
