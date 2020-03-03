using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ClubCategoryTypeController : BaseController<ClubCategoryType>
    {
        public ClubCategoryTypeController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [HttpGet("ByCategoryId/{clubCategoryId}")]
        public IQueryable<ClubCategoryType> Get(Guid clubCategoryId)
        {
            return _repository.Query<ClubCategoryType>().Where(x => x.ClubCategoryId == clubCategoryId);
        }
    }
}
