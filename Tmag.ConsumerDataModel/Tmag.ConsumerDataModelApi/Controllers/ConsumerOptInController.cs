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
    public class ConsumerOptInController : BaseController<ConsumerOptIn>
    {
        public ConsumerOptInController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [HttpPost]
        [Route("AddUpdate")]
        public IActionResult Save([FromBody]ConsumerOptInTo value)
        {
            if (value.ConsumerOptInId.HasValue)
            {
                var optIn = _repository.Query<ConsumerOptIn>().FirstOrDefault(x => x.Id == value.ConsumerOptInId);
                if (optIn == null) return BadRequest("opt in id provided but no opt in found");

                optIn.Value = value.Value;
                _repository.Save();

                return Ok(optIn);
            }
            else
            {
                var consumerProfile = _repository.Query<ConsumerProfile>()
                    .FirstOrDefault(x => x.RegionId == value.RegionId && x.ConsumerId == value.ConsumerId);

                if (consumerProfile == null) return BadRequest("consumer profile not found");

                var optIn = _repository.Query<ConsumerProfile>()
                    .Where(x => x.RegionId == value.RegionId && x.ConsumerId == value.ConsumerId)
                    .Include(x => x.ConsumerOptIns)
                    .SelectMany(x => x.ConsumerOptIns).FirstOrDefault(x => x.Key == value.Key);

                if(optIn != null)
                {
                    optIn.Value = value.Value;
                } else
                {
                    optIn = new ConsumerOptIn()
                    {
                        ConsumerProfileId = consumerProfile.Id.Value,
                        Value = value.Value,
                        Key = value.Key
                    };
                    _repository.SaveQueue(optIn);
                }
                _repository.Save();

                return Ok(optIn);
            }
        }
    }
}
