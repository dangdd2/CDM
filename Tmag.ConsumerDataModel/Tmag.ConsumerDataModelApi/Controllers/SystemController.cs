using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class SystemController : BaseController<ConsumerData.Models.System>
    {
        public SystemController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }
    }
}
