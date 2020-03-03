using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Route("api/[controller]")]
    public class ClubLieController : BaseController<ClubLie>
    {
        public ClubLieController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }
    }
}
