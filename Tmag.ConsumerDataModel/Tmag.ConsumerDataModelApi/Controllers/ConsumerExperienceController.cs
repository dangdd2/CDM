using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Microsoft.AspNetCore.Authorization;
using Tmag.ConsumerDataModelApi.TOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ConsumerExperienceController : BaseController<ConsumerExperience>
    {        
        public ConsumerExperienceController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }
        [HttpGet("query")]
        public IActionResult GetExperiences([FromQuery]Guid regionId,
            [FromQuery]Guid? experienceId = null, [FromQuery]Guid? consumerId = null,
           [FromQuery]string email = null)
        {
            var experiences = _repository.Query<ConsumerExperience>();
            

            if (experienceId.HasValue)
                experiences = experiences.Where(x => x.Id == experienceId);
            else if (consumerId.HasValue)
                experiences = experiences.Where(x => x.ConsumerProfile.ConsumerId == consumerId && x.ConsumerProfile.RegionId == regionId);
            else
                experiences = experiences.Where(x => x.ConsumerProfile.Consumer.PrimaryEmail.ToLower() == email.ToLower());



            return Ok(experiences
             .Include(x => x.Address).ToList());
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]ExperienceTo value)
        {
            if(!value.RegionId.HasValue)
                return BadRequest("Region Id required");

            var consumerExperience = value.ConsumerExperience;           
            var consumerProfileQ = _repository.Query<ConsumerProfile>();

            if (value.ConsumerId.HasValue)
                consumerProfileQ = consumerProfileQ.Where(x => x.ConsumerId == value.ConsumerId);
            else if (!string.IsNullOrWhiteSpace(value.Email))
                consumerProfileQ = consumerProfileQ.Where(x => x.Consumer.PrimaryEmail.ToLower() == value.Email);
            else
                return BadRequest("Consumer Id or email must be provided");
            
            var consumerProfile = consumerProfileQ.AsNoTracking().FirstOrDefault(x => x.RegionId == value.RegionId);
            
            if(consumerProfile == null)
                return BadRequest("Consumer not found");

            if (consumerProfile.Id != null) consumerExperience.ConsumerProfileId = consumerProfile.Id.Value;


            _repository.Save(consumerExperience);

            return Ok(consumerExperience);
        }
    }
}
