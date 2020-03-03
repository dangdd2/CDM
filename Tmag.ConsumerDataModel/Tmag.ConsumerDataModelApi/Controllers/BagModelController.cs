﻿using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class BagModelController : BaseController<BagModel>
    {
        public BagModelController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }
    }
}
