﻿using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Repositories;
using Tmag.ConsumerData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ClubCategoryController : BaseController<ClubCategory>
    {
        public ClubCategoryController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }
    }
}
