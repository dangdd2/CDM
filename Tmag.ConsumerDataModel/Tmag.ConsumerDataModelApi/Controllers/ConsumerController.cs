using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tmag.ConsumerDataModelApi.Helper;
using Tmag.ConsumerDataModelApi.TOs;
using Tmag.Identity;
using Serilog;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ConsumerController : BaseController<Consumer>
    {
        private readonly IUserClaimResolver _userClaimResolver;



        public ConsumerController(IRepository repository, 
                              IUserClaimResolver userClaimResolver,
                              ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
            _userClaimResolver = userClaimResolver;
        }

        [HttpGet("query")]
        public IActionResult GetWithOptions(
                                            [FromQuery] string regionId, 
                                            [FromQuery] string consumerId = null, 
                                            [FromQuery] string email = null,
                                            [FromQuery] string systemId = null, 
                                            [FromQuery] int take = 100, 
                                            [FromQuery] int skip = 0
                                            )
        {
            Guid consumerIdValue;
            Guid regionIdValue;
            Guid systemIdValue;

            
            if (!string.IsNullOrEmpty(consumerId))
            {                
                bool isValid = Guid.TryParse(consumerId, out consumerIdValue);
                if (!isValid) return BadRequest(ValidationMessages.ConsumerIdIsNotValid);
            }



            if (consumerId == null && email == null)
            {
                return BadRequest(ValidationMessages.EmailOrConsumerIdRequired);
            }

            if (!string.IsNullOrEmpty(consumerId))
            {                
                bool isValid = Guid.TryParse(consumerId, out consumerIdValue);
                if (!isValid) return BadRequest(ValidationMessages.ConsumerIdIsNotValid);
            }


            if (!string.IsNullOrEmpty(regionId))
            {
                bool isValid = Guid.TryParse(regionId, out regionIdValue);
                if (!isValid) return BadRequest(ValidationMessages.RegionIdIsNotValid);
            }


            if (!string.IsNullOrEmpty(systemId))
            {
                bool isValid = Guid.TryParse(systemId, out systemIdValue);
                if (!isValid) return BadRequest(ValidationMessages.SystemIdIsNotValid);
            }


            bool consumerIdHasValue = consumerIdValue != Guid.Empty;
            bool systemIdHasValue = systemIdValue != Guid.Empty;
            bool regionIdHasValue = regionIdValue != Guid.Empty;
            var query = _repository.Query<Consumer>().Where(x => !x.Deleted.HasValue);

            if (consumerIdHasValue)
                query = query.Where(x => x.Id == consumerIdValue);
            else if (email != null)
                query = query.Where(x => x.PrimaryEmail == email);


            if (systemIdHasValue && regionIdHasValue) 
                query = query.Where(x => x.ConsumerProfiles.Any(y => y.RegionId == regionIdValue && y.SystemToConsumerProfiles.Any(a => a.SystemId == systemIdValue)));
            
            query = query
                .Include(x => x.GolferProfile).ThenInclude(x => x.DriverLoft)
                .Include(x => x.GolferProfile).ThenInclude(x => x.ClubHand)
                .Include(x => x.GolferProfile).ThenInclude(x => x.CurrentDriverFlex)
                .Include(x => x.GolferProfile).ThenInclude(x => x.CurrentIronLength)
                .Include(x => x.GolferProfile).ThenInclude(x => x.CurrentIronLie)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.ClubShaftLength)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.ClubShaftFlex)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.ClubCategoryType)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.FaceLoftAdjustment)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.FaceLieAdjustment)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.ClubLoft)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.ClubCategory)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.Brand)
                .Include(x => x.GolferProfile).ThenInclude(x => x.WhatsInTheBags).ThenInclude(x => x.Model);



            if (consumerIdHasValue || email != null)
            {
                var consumer = query.FirstOrDefault();
                if (consumer == null) return BadRequest(ValidationMessages.ConsumerNotFound);

                consumer.ConsumerProfiles = _repository.Query<ConsumerProfile>(x => x.RegionId == regionIdValue && x.ConsumerId == consumer.Id)
                                                        .Include(x => x.Address).Include(x => x.ConsumerOptIns)
                                                        .ToList();
                return Ok(consumer);
            }

            var list = query.AsNoTracking().Skip(skip).Take(take).ToList();
            foreach (var consumer in list)
            {
                consumer.ConsumerProfiles = _repository.Query<ConsumerProfile>(x => x.RegionId == regionIdValue && x.ConsumerId == consumer.Id)
                                                        .Include(x => x.Address).Include(x => x.ConsumerOptIns).ToList();
            }
            return Ok(list);
        }

        [HttpPost]
        [Route("AddUpdate")]
        public IActionResult Create([FromBody]ConsumerTo consumerModel)
        {
            if (consumerModel.RegionId == null) return BadRequest(ValidationMessages.RegionIdRequired);
            if (!IsValidSystemId(consumerModel.SystemId))
                return BadRequest(ValidationMessages.SystemIdRequired);
            //if we have the postal then the country must be provided
            if (consumerModel.Postalcode != null && string.IsNullOrEmpty(consumerModel.Country)) 
                return BadRequest(ValidationMessages.CountryRequired);
            if (!IsValidEmail(consumerModel.Email))
                return BadRequest(ValidationMessages.InvalidEmailFormat);

            return AddUpdate(consumerModel, true);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateNew([FromBody]ConsumerTo consumerModel)
        {
            if (consumerModel.RegionId == null) return BadRequest(ValidationMessages.RegionIdRequired);
            if (consumerModel.ConsumerId != null) return BadRequest(ValidationMessages.ConsumerNoNeedToProvided);
            if (consumerModel.Email == null) return BadRequest(ValidationMessages.EmailRequired);

            if (!IsValidSystemId(consumerModel.SystemId))
                return BadRequest(ValidationMessages.SystemIdRequired);
            if (!IsValidEmail(consumerModel.Email)) 
                return BadRequest(ValidationMessages.InvalidEmailFormat);

            /* 04/29 TL check if consumer already exists with the provided email, return  consumer already exists to force 
                       client to use update or addUpdate endpoint
                       query database that provided email exists  */
            var existingConsumer = _repository.Query<Consumer>().AsNoTracking().FirstOrDefault(x => x.PrimaryEmail == consumerModel.Email);
            if(existingConsumer != null ) 
                return BadRequest(ValidationMessages.ConsumerAlreadyExists);

            /* Client must provide a zipcode then country string must be also provided */
            if (consumerModel.Postalcode != null && string.IsNullOrEmpty(consumerModel.Country)) 
                return BadRequest(ValidationMessages.CountryRequired);

            return AddUpdate(consumerModel, true);
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update([FromBody]ConsumerTo consumerModel)
        { 
            if (consumerModel.ConsumerId == null) 
                return BadRequest(ValidationMessages.ConsumerIdRequired);
            if (consumerModel.RegionId == null) 
                return BadRequest(ValidationMessages.RegionIdRequired);
            if (!IsValidSystemId(consumerModel.SystemId))
                return BadRequest(ValidationMessages.SystemIdRequired);
            if (!IsValidEmail(consumerModel.Email))
                    return BadRequest(ValidationMessages.InvalidEmailFormat);

            var oldConsumer = _repository.Query<Consumer>().AsNoTracking().FirstOrDefault(x => x.Id == consumerModel.ConsumerId);

            if (oldConsumer == null)
                return BadRequest(ValidationMessages.ConsumerNotFound);
            if (oldConsumer.PrimaryEmail.ToLower() != consumerModel.Email.ToLower())
            {
                var user = _userClaimResolver.Resolve();
                var canChangeEmail = user.Claims.FirstOrDefault(x => x.Type == "CanChangeEmail");
                if (canChangeEmail == null || !Convert.ToBoolean(canChangeEmail.Value))
                {
                    return BadRequest(ValidationMessages.ConsumerFoundButEmailIsNotMatch);
                }
            }
                
            return AddUpdate(consumerModel, true);
        }

        public IActionResult AddUpdate(ConsumerTo consumerModel, bool allowUpdateEmail = false)
        {
            Consumer consumer = null;
            var cdmItemQ = _repository.Query<Consumer>();

            if (consumerModel.ConsumerProfileId.HasValue)
                consumer = cdmItemQ.FirstOrDefault(x => x.ConsumerProfiles.Any(y => y.Id == consumerModel.ConsumerProfileId));
            else if (consumerModel.ConsumerId.HasValue)
                consumer = cdmItemQ.FirstOrDefault(x => x.Id == consumerModel.ConsumerId);
            else if (consumerModel.Email != null)
                consumer = cdmItemQ.FirstOrDefault(x => x.PrimaryEmail == consumerModel.Email);

            if (consumer == null) // if not matched with any credential above then we need to create new consumer
            {
                if (consumerModel.Email == null)
                {
                    return BadRequest(ValidationMessages.EmailRequired);
                }
                consumer = new Consumer();
                
            }
            else
            {
                consumer.Deleted = null;
                consumer.GolferProfile = _repository.Query<GolferProfile>(x => x.ConsumerId == consumer.Id).FirstOrDefault();
                consumer.ConsumerProfiles = _repository.Query<ConsumerProfile>(x => x.ConsumerId == consumer.Id)
                                                        .Include(x => x.ConsumerOptIns)                  
                                                        .ToList();
                if(consumer.ConsumerProfiles != null && consumer.ConsumerProfiles.Any())
                {
                    var addressIds = consumer.ConsumerProfiles.Select(x => x.AddressId).ToList();
                    var consumerProfileIds = consumer.ConsumerProfiles.Select(x => x.Id).ToList();

                    var address = _repository.Query<Address>(x => addressIds.Contains(x.Id)).ToList();
                    var systemToConsumerProfiles = _repository.Query<SystemToConsumerProfile>(x => consumerProfileIds.Contains(x.ConsumerProfileId)).ToList();

                    foreach (var consumerProfile in consumer.ConsumerProfiles)
                    {
                        consumerProfile.Address = address.FirstOrDefault(x => x.Id == consumerProfile.AddressId);
                        consumerProfile.SystemToConsumerProfiles = systemToConsumerProfiles.Where(x => x.ConsumerProfileId == consumerProfile.Id).ToList();
                    }
                }
            }

            UpdateConsumer(consumerModel, allowUpdateEmail, consumer);

            if(consumerModel.RegionId == null) throw new Exception(ValidationMessages.RegionIdRequired);

            if (consumer.ConsumerProfiles != null)
            {
                var consumerProfiles = consumer.ConsumerProfiles.Where(x => x.RegionId == consumerModel.RegionId.Value).ToList();
                if (consumerProfiles.Any())
                {
                    foreach (var consumerProfile in consumerProfiles)
                    {
                        CreateOrUpdateConsumerProfile(consumerModel, consumerProfile, consumer);
                    }
                }
                else
                {
                    CreateNewConsumerProfile(consumerModel, consumer);
                }
                                 
            }
            else
            {
                CreateNewConsumerProfile(consumerModel, consumer);
            }

            var golferProfile = consumer.GolferProfile ?? new GolferProfile();
            CreateOrUpdateGolfProfile(consumerModel, golferProfile, consumer);
            
            _repository.Save(consumer);
            return Ok(consumer);
        }

        private static void CreateNewConsumerProfile(ConsumerTo consumerModel, Consumer consumer)
        {
            var consumerProfile = new ConsumerProfile();
            CreateOrUpdateConsumerProfile(consumerModel, consumerProfile, consumer);
        }

        private static void UpdateConsumer(ConsumerTo consumerModel, bool allowUpdateEmail, Consumer consumer)
        {
            if (consumerModel.FirstName != null)
                consumer.FirstName = consumerModel.FirstName;
            if (consumerModel.LastName != null)
                consumer.LastName = consumerModel.LastName;
            if (allowUpdateEmail && consumerModel.Email != null)
                consumer.PrimaryEmail = consumerModel.Email;
            if (consumerModel.Dob != null)
                consumer.Dob = consumerModel.Dob;
            if (consumerModel.Gender != null)
                consumer.Gender = consumerModel.Gender;
            if (consumerModel.GenderId != null)
                consumer.GenderId = consumerModel.GenderId;
            if (consumerModel.FirstNameKana != null)
                consumer.FirstNameKana = consumerModel.FirstNameKana;
            if (consumerModel.LastNameKana != null)
                consumer.LastNameKana = consumerModel.LastNameKana;
        }

        private static void CreateOrUpdateGolfProfile(ConsumerTo consumerModel, GolferProfile golferProfile, Consumer consumer)
        {
            if (consumerModel.Handicap != null)
                golferProfile.Handicap = consumerModel.Handicap;
            if (consumerModel.DriverLoftId != null)
                golferProfile.DriverLoftId = consumerModel.DriverLoftId;
            if (consumerModel.CurrentDriverFlexId != null)
                golferProfile.CurrentDriverFlexId = consumerModel.CurrentDriverFlexId;
            if (consumerModel.CurrentDriverBallFlight != null)
                golferProfile.CurrentDriverBallFlight = consumerModel.CurrentDriverBallFlight;
            if (consumerModel.DesiredDriverBallFlight != null)
                golferProfile.DesiredDriverBallFlight = consumerModel.DesiredDriverBallFlight;
            if (consumerModel.TypicalDriverDistance != null)
                golferProfile.TypicalDriverDistance = consumerModel.TypicalDriverDistance;
            if (consumerModel.CurrentIronLengthId != null)
                golferProfile.CurrentIronLengthId = consumerModel.CurrentIronLengthId;
            if (consumerModel.Current7IronBallFlight != null)
                golferProfile.Current7IronBallFlight = consumerModel.Current7IronBallFlight;
            if (consumerModel.CurrentIronLieId != null)
                golferProfile.CurrentIronLieId = consumerModel.CurrentIronLieId;
            if (consumerModel.Desired7IronBallFlight != null)
                golferProfile.Desired7IronBallFlight = consumerModel.Desired7IronBallFlight;
            if (consumerModel.Typical7IronDistance != null)
                golferProfile.Typical7IronDistance = consumerModel.Typical7IronDistance;
            if (consumerModel.DesiredDriverFlexId != null)
                golferProfile.DesiredDriverFlexId = consumerModel.DesiredDriverFlexId;
            if (consumerModel.Rpm != null)
                golferProfile.RoundsPerMonth = consumerModel.Rpm.Value;
            if (consumerModel.ClubHandId != null)
                golferProfile.ClubHandId = consumerModel.ClubHandId;

            if (!golferProfile.Id.HasValue)
                consumer.GolferProfile = golferProfile;
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsValidSystemId( Guid systemId)
        {
            /* 05/01/2019 TL seems that systemId is always 00000000-0000-0000-0000-000000000000, even when request does not have systemId in the body 
               so we consider "00000000-0000-0000-0000-000000000000" as non valid 
            */
            string systemIdStr = systemId.ToString();
            if (systemIdStr.CompareTo("00000000-0000-0000-0000-000000000000") == 0)
                return false;
            return true;
        }

        private static void CreateOrUpdateConsumerProfile(ConsumerTo consumerModel, ConsumerProfile consumerProfile, Consumer cdmItem)
        {
            Debug.Assert(consumerModel.RegionId != null, "consumerModel.RegionId != null");
            consumerProfile.RegionId = consumerModel.RegionId.Value;

            if (consumerModel.PhoneHome != null)
                consumerProfile.PhoneHome = consumerModel.PhoneHome;
            if (consumerModel.PhoneCell != null)
                consumerProfile.PhoneCell = consumerModel.PhoneCell;
            if (consumerModel.Description != null)
                consumerProfile.Notes = consumerModel.Description;
            if (consumerModel.MemberRank != null)
                consumerProfile.MemberRank = consumerModel.MemberRank;
            if (consumerProfile.SystemToConsumerProfiles == null)
                consumerProfile.SystemToConsumerProfiles = new List<SystemToConsumerProfile>();

            if (consumerProfile.SystemToConsumerProfiles.All(x => x.SystemId != consumerModel.SystemId))
            {
                consumerProfile.SystemToConsumerProfiles.Add(
                    new SystemToConsumerProfile
                    {
                        SystemId = consumerModel.SystemId,
                        Created = DateTime.UtcNow
                    });
            }

            if (cdmItem.ConsumerProfiles == null)
            {
                cdmItem.ConsumerProfiles = new List<ConsumerProfile> {consumerProfile};
            }
            else if (!consumerProfile.Id.HasValue) //when consumer profile id is NULL then add new profile
            {
                cdmItem.ConsumerProfiles.Add(consumerProfile);
            }

            if (consumerModel.Postalcode != null)
            {                                
                var address = consumerProfile.Address ?? new Address();
                address.ZipCode = consumerModel.Postalcode;
                address.State = consumerModel.State;
                address.Country = consumerModel.Country;
                address.Created = DateTime.UtcNow;
                address.SystemId = consumerModel.SystemId;
                address.AddressLine1 = consumerModel.AddressLine1;
                address.AddressLine2 = consumerModel.AddressLine2;
                address.AddressLine3 = consumerModel.AddressLine3;
                address.City = consumerModel.City;
                if (!address.Id.HasValue)
                    consumerProfile.Address = address;
            }
        }
    }
}

