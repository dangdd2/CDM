using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tmag.Common.Repositories;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    /// <summary></summary>
    [Route("api/[controller]")]

    [Route("")]

    public class ValuesController : Controller
    {
        protected readonly ILogger _logger;
        protected readonly IRepository _repository;
        public ValuesController(IRepository repository, ILoggerFactory loggerFactory)
        {
            _repository = repository;
            _logger = loggerFactory.CreateLogger("ValuesController");
        }

        public IActionResult Index()
        {           
            return Ok("The CDM is up and running ...");
        }

    }
}