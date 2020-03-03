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
    public class BagPanelFontController : BaseController<BagPanelFont>
    {
        public BagPanelFontController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [Route("create")]
        public IActionResult Create([FromBody]BagPanelTo bagPanelTo)
        {
            var consumerProfile = _repository.Query<ConsumerProfile>().Include(x => x.Consumer).ThenInclude(x => x.GolferProfile)
                .FirstOrDefault(x => x.RegionId == bagPanelTo.RegionId && 
                                    x.Consumer.PrimaryEmail.ToLower() == bagPanelTo.Email.ToLower());
            if (consumerProfile == null)
            {
                return BadRequest("consumer profile not found");
            }
            var consumberBagPanel = new ConsumerBagPanelCampaign();

            consumberBagPanel.Address = new Address()
            {
                AddressLine1 = bagPanelTo.Address,
                AddressLine2 = bagPanelTo.AddressLine2,
                City = bagPanelTo.City,
                State = bagPanelTo.Country,
                ZipCode = bagPanelTo.ZipCode
            };

            consumberBagPanel.BagModelId = bagPanelTo.BagModelId;
            consumberBagPanel.BagPanelFontId = bagPanelTo.FontId;
            consumberBagPanel.BagUsage = bagPanelTo.BagUsage;           
            consumberBagPanel.ConsumerProfileId = consumerProfile.Id.Value;
            consumberBagPanel.ItemNumber = bagPanelTo.ItemNumber;
            consumberBagPanel.PointOfPurchaseId = bagPanelTo.PointOfPurchaseId;
            consumberBagPanel.Sku = bagPanelTo.Sku;
            consumberBagPanel.TextLine1 = bagPanelTo.TextLine1;
            consumberBagPanel.TextLine2 = bagPanelTo.TextLine2;
            consumberBagPanel.TextLine3 = bagPanelTo.TextLine3;
            consumberBagPanel.BagColor = bagPanelTo.BagColor;
            consumberBagPanel.BagTopQuality = bagPanelTo.BagTopQuality;
            consumberBagPanel.OptInBrand = bagPanelTo.OptInBrand;

            if (consumerProfile.Consumer.GolferProfile == null)
            {
                consumerProfile.Consumer.GolferProfile = new GolferProfile();
            }

            consumerProfile.Consumer.GolferProfile.Handicap = bagPanelTo.Handicap;
            consumerProfile.Consumer.GolferProfile.RoundsPerMonth = bagPanelTo.RoundsPerMonth;

            _repository.SaveQueue(consumberBagPanel);

            _repository.Save();

            return Ok(consumberBagPanel);
        }
    }
}
