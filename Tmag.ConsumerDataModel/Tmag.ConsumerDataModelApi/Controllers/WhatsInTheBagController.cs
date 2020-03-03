using System;
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
    public class WhatsInTheBagController : BaseController<WhatsInTheBag>
    {
        public WhatsInTheBagController(IRepository repository, ILoggerFactory loggerFactory) : base(repository, loggerFactory)
        {
        }

        [HttpGet("query")]
        public IActionResult GetWhatsInTheBag([FromQuery]Guid? whatsInTheBagId = null, [FromQuery]Guid? consumerId = null, 
            [FromQuery]string email = null, [FromQuery]bool? deleted = null)
        {
            var whatsInTheBag = _repository.Query<WhatsInTheBag>();

            if (!deleted.HasValue || !deleted.Value)
                whatsInTheBag = whatsInTheBag.Where(x => x.Deleted.HasValue);

            if (whatsInTheBagId.HasValue)
                whatsInTheBag = whatsInTheBag.Where(x => x.Id == whatsInTheBagId);
            else if (consumerId.HasValue)
                whatsInTheBag = whatsInTheBag.Where(x => x.GolferProfile.ConsumerId == consumerId);
            else
                whatsInTheBag = whatsInTheBag.Where(x => x.GolferProfile.Consumer.PrimaryEmail.ToLower() == email.ToLower());



            return Ok(whatsInTheBag
             .Include(x => x.ClubShaftLength)
                .Include(x => x.ClubShaftFlex)
                .Include(x => x.ClubCategoryType)
                .Include(x => x.FaceLoftAdjustment)
                .Include(x => x.FaceLieAdjustment)
                .Include(x => x.ClubLoft)
                .Include(x => x.ClubCategory)
                .Include(x => x.Brand)
                .Include(x => x.Model).ToList());
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]WhatsInTheBagTo value)
        {
            if (value == null) return BadRequest("Data model could not be null");

            var cdmItem = new WhatsInTheBag();
            cdmItem.ClubShaftFlexId = value.ClubShaftFlexId;
            cdmItem.ClubLoftId = value.ClubLoftId;
            cdmItem.FaceLieAdjustmentId = value.FaceLieAdjustmentId;
            cdmItem.FaceLoftAdjustmentId = value.FaceLoftAdjustmentId;
            cdmItem.Created = DateTime.UtcNow;
            cdmItem.ClubCategoryId = value.CategoryId;
            cdmItem.BrandId = value.BrandId;
            cdmItem.ClubCategoryTypeId = value.ClubCategoryTypeId;
            cdmItem.ModelId = value.ModelId;
            cdmItem.PlanToPurchase = value.PlanningToPurchase;
            cdmItem.ClubShaftLengthId = value.ClubShaftLengthId;
            cdmItem.Sku = value.Sku;

            var consumer = _repository.Query<Consumer>().Include(y => y.GolferProfile)
                .FirstOrDefault(y => y.Id == value.ConsumerId);

            if (consumer == null) return BadRequest("Consumer not found.");

            if (consumer.GolferProfile == null)
            {
                var profile = new GolferProfile();
                profile.Created = DateTime.UtcNow;
                profile.ConsumerId = consumer.Id.Value;
                _repository.Save(profile);
                cdmItem.GolferProfileId = profile.Id;
            }
            else{
                cdmItem.GolferProfileId = consumer.GolferProfile.Id;
            }



            _repository.Save(cdmItem);
            return Ok(_repository.Query<WhatsInTheBag>().Include(x => x.ClubShaftLength)
                .Include(x => x.ClubShaftFlex)
                .Include(x => x.ClubCategoryType)
                .Include(x => x.FaceLoftAdjustment)
                .Include(x => x.FaceLieAdjustment)
                .Include(x => x.ClubLoft)
                .Include(x => x.ClubCategory)
                .Include(x => x.Brand)
                .Include(x => x.Model).FirstOrDefault(x => x.Id == cdmItem.Id));
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update([FromBody]WhatsInTheBagTo value)
        {

            var cdmItem = _repository.Query<WhatsInTheBag>().FirstOrDefault(x => x.Id == value.Id);

            if (cdmItem == null) return BadRequest("Whats in the bag id not found");

            cdmItem.ClubShaftFlexId = value.ClubShaftFlexId;
            cdmItem.ClubLoftId = value.ClubLoftId;
            cdmItem.FaceLieAdjustmentId = value.FaceLieAdjustmentId;
            cdmItem.FaceLoftAdjustmentId = value.FaceLoftAdjustmentId;
            cdmItem.Created = DateTime.UtcNow;
            cdmItem.ClubCategoryId = value.CategoryId;
            cdmItem.BrandId = value.BrandId;
            cdmItem.ClubCategoryTypeId = value.ClubCategoryTypeId;
            cdmItem.ModelId = value.ModelId;
            cdmItem.PlanToPurchase = value.PlanningToPurchase;
            cdmItem.ClubShaftLengthId = value.ClubShaftLengthId;
            cdmItem.Sku = value.Sku;
            cdmItem.Deleted = value.Deleted;

            var consumer = _repository.Query<Consumer>().Include(y => y.GolferProfile)
                .FirstOrDefault(y => y.Id == value.ConsumerId);
            
            cdmItem.GolferProfileId = consumer.GolferProfile.Id;


            _repository.Save(cdmItem);
            return Ok(_repository.Query<WhatsInTheBag>().Include(x => x.ClubShaftLength)
                .Include(x => x.ClubShaftFlex)
                .Include(x => x.ClubCategoryType)
                .Include(x => x.FaceLoftAdjustment)
                .Include(x => x.FaceLieAdjustment)
                .Include(x => x.ClubLoft)
                .Include(x => x.ClubCategory)
                .Include(x => x.Brand)
                .Include(x => x.Model).FirstOrDefault(x => x.Id == cdmItem.Id));
        }
    }
}
