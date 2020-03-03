using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;

namespace Tmag.SugarOneOffDataTransferJob
{
    public class Experiences
    {
        private readonly IRepository _repository;
        private readonly ILogger<Consumer> _logger;
        private readonly StaticTableHelper _staticTableHelper;
        private readonly int _splitCount = 60;
        private  int _startCount = 0;

        public Experiences(IRepository repository, 
            ILogger<Consumer> logger, StaticTableHelper staticTableHelper, IOptions<LoadSettings> settings)
        {
            _repository = repository;
            _logger = logger;
            _staticTableHelper = staticTableHelper;
            _startCount = settings.Value.StartCount;
        }
        private List<string> emailsSaved = new List<string>();
        public void Migrate()
        {
            try
            {
                _logger.LogInformation("################# Migration of Experiences");
                
                var systemId = getSystemId();
                var regionId = _repository.Query<Region>().FirstOrDefault(y => y.Code == "USA").Id.Value;

                var experiences =  _repository.Query<ConsumerExperienceTransfer>().ToList();
                var countFromSugar = experiences.Count();

                var loopCount = countFromSugar / _splitCount;

                for (var x = 0; x < loopCount; x++)
                {
                    var skip = _startCount + (x * _splitCount);
                    if (skip > countFromSugar) break;
                    _logger.LogInformation($"Starting segment starting at {skip}");

                    _repository.ReloadContext();
                    _repository.GetDatabase().ChangeTracker.AutoDetectChangesEnabled = false;
                    var sugarItems = experiences.Skip(skip).Take(_splitCount).ToList();
                    foreach (var exSugar in sugarItems)
                    {
                        try
                        {
                            var consumer = _repository.Query<ConsumerData.Models.ConsumerProfile>().AsNoTracking()
                                .FirstOrDefault(y => y.Consumer.PrimaryEmail.ToLower() == exSugar.consumerEmail.ToLower()
                                && y.RegionId == regionId);

                            if (consumer == null)
                            {
                                _logger.LogInformation("Did not find consumer skipping");
                            }

                            var experience = new ConsumerExperience();
                            experience.ExperienceDate = exSugar.experienceDate;
                            experience.Created = exSugar.experienceDate;
                            experience.Modified = exSugar.experienceDate;
                            if (!string.IsNullOrWhiteSpace(exSugar.postalCode))
                            {
                                experience.Address = new Address();
                                experience.Address.AddressLine1 = exSugar.address1;
                                experience.Address.AddressLine2 = exSugar.address2;
                                experience.Address.City = exSugar.city;
                                experience.Address.State = exSugar.state;
                                experience.Address.Country = "USA";
                                experience.Address.ZipCode = exSugar.postalCode;
                                experience.Address.SystemId = systemId;
                            }
                            experience.EventName = exSugar.locationName;
                            experience.ConsumerProfileId = consumer.Id.Value;
                            _repository.SaveQueue(experience);
                          
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex.Message);
                            _logger.LogError("Saved experience failed");
                        }
                    }

                    try
                    {
                        _logger.LogError("saving experiences");
                        _repository.Save();
                        _logger.LogError("done saving moving to next batch");
                    }
                    catch (Exception e)
                    {
                        _logger.LogError("failed", e);

                        if (e.Message != null)
                            _logger.LogError(e.Message);
                        _logger.LogError(e.StackTrace);
                        if (e.InnerException != null && e.InnerException.Message != null)
                            _logger.LogError(e.InnerException.Message);
                    }
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
