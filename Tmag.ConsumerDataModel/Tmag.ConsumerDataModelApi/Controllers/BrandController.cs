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
    public class BrandController : BaseController<Brand>
    {
        public BrandController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [HttpGet("ByCategoryId/{clubCategoryId}")]
        public IQueryable<Brand> Get1(Guid clubCategoryId)
        {
            _logger.LogInformation("Calling the [brand controller] with club categoryId : " + clubCategoryId);
            return _repository.Query<Brand>().Where(x => x.ClubCategoryId == clubCategoryId);
        }
    }
}
