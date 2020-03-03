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
    public class ClubLoftController : BaseController<ClubLoft>
    {
        public ClubLoftController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [HttpGet("ByCategoryId/{clubCategoryId}")]
        public IQueryable<ClubLoft> Get1(Guid clubCategoryId)
        {
            return _repository.Query<ClubLoft>().Where(x => x.ClubCategoryId == clubCategoryId);
        }
    }
}
