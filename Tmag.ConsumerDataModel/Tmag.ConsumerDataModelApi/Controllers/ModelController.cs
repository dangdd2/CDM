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
    public class ModelController : BaseController<Model>
    {
        public ModelController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [HttpGet("bybrandid/{brandId}")]
        public IQueryable<Model> Get1(Guid brandId)
        {
            return _repository.Query<Model>().Where(x => x.BrandId == brandId && !x.Deleted.HasValue);
        }
    }
}
