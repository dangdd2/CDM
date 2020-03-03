using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Tmag.Common.Repositories;
using Tmag.SugarOneOffDataTransferJob.Models;

namespace Tmag.SugarOneOffDataTransferJob
{
    public class WhatsInTheBag
    {
        private readonly IRepository _repository;
        private readonly SugarDataContext _sugarDataContext;
        private readonly ILogger<Consumer> _logger;
        private readonly StaticTableHelper _staticTableHelper;
        private readonly int _splitCount = 30;

        public WhatsInTheBag(IRepository repository, SugarDataContext sugarDataContext,
            ILogger<Consumer> logger, StaticTableHelper staticTableHelper)
        {
            _repository = repository;
            _sugarDataContext = sugarDataContext;
            _logger = logger;
            _staticTableHelper = staticTableHelper;
        }
        public void Migrate()
        {
            try
            {
                var consumersFromSugar = _sugarDataContext.Query<WWhatsInTheBag>().OrderByDescending(x => x.DateModified).ToList();
                var whatsInTheBagSugar = _sugarDataContext.Query<WWhatsInTheBagCstm>().ToList();
                var whatsInToConsumerSugar = _sugarDataContext.Query<WWhatsInTheBagCConsumersC>();
                var countFromSugar = consumersFromSugar.Count;

                var loopCount = countFromSugar / _splitCount;

                if (loopCount > 0) loopCount = countFromSugar;
                
                _logger.LogInformation("#################Starting Migration of Whats in the bag");
                _logger.LogInformation($"Found {countFromSugar} to migrate");

                for (var x = 0; x < loopCount; x++)
                {
                    var skip = x * _splitCount;
                    if (skip > countFromSugar) break;
                    _logger.LogInformation($"Starting segment starting at {skip}");

                    _repository.ReloadContext();
                    _repository.GetDatabase().ChangeTracker.AutoDetectChangesEnabled = false;
                    var sugarItems = consumersFromSugar.Skip(x * _splitCount).Take(_splitCount).ToList();

                    foreach (var sItem in sugarItems)
                    {
                        
                        var bagItem = whatsInTheBagSugar.FirstOrDefault(y => y.IdC == sItem.Id);                        
                        var itemToConsumer = whatsInToConsumerSugar.FirstOrDefault(y => y.WWhatsInTheBagCConsumerswWhatsInTheBagIdb == sItem.Id);
                        var consumerOld = _sugarDataContext.Query<CConsumers>().FirstOrDefault(y => y.Id == itemToConsumer.WWhatsInTheBagCConsumerscConsumersIda);

                        if (consumerOld == null)
                        {
                            continue;
                        }

                        var consumer = _repository.Query<ConsumerData.Models.Consumer>()
                                            .Include(y => y.GolferProfile)
                                            .FirstOrDefault(y => y.PrimaryEmail.ToLower() == consumerOld.Email.ToLower());
                        if (consumer == null)
                        {
                            continue;
                        }
                        if (consumer.GolferProfile == null)
                        {
                            consumer.GolferProfile = new ConsumerData.Models.GolferProfile
                            {
                                Created = DateTime.UtcNow,
                                ConsumerId = consumer.Id.Value
                            };
                            _repository.SaveQueue(consumer);
                        }

                        var cdmItem = new ConsumerData.Models.WhatsInTheBag
                        {
                            ClubShaftFlexId = _staticTableHelper.GetFlexId(bagItem.FlexC),
                            ClubLoftId = _staticTableHelper.GetLoftId(bagItem.LoftC),
                            FaceLieAdjustmentId = _staticTableHelper.GetLieId(bagItem.FaceLieAdjustmentC),
                            FaceLoftAdjustmentId = _staticTableHelper.GetLoftId(bagItem.FaceLoftAdjustmentC),
                            Created = DateTime.UtcNow,
                            ClubCategoryId = _staticTableHelper.GetCategoryId(sItem.Category),
                            BrandId = _staticTableHelper.GetBrandId(sItem.Vendor),
                            ClubCategoryTypeId = _staticTableHelper.GetClubCategoryTypeId(bagItem.HeadLoftC),
                            ModelId = _staticTableHelper.GetModelId(sItem.Model),
                            PlanToPurchase = !string.IsNullOrWhiteSpace(sItem.PlanningToPurchase),
                            ClubShaftLengthId = _staticTableHelper.GetChaftLengthId(bagItem.ShaftLengthC),
                            Sku = bagItem.SkuC,
                            GolferProfileId = consumer.GolferProfile.Id
                        };

                        try
                        {
                            _repository.SaveQueue(cdmItem);
                        }
                        catch (Exception e)
                        {
                            _logger.LogError(e.Message);
                        }
                    }

                    _logger.LogInformation($"Saving Whats in the bag " + DateTime.UtcNow.ToLongDateString());
                    try
                    {
                        _repository.Save();
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e.Message);
                    }
                    _logger.LogInformation($"Saving Whats in the bag" + DateTime.UtcNow.ToLongDateString());
                }

            }
            catch (Exception e)
            {
                _logger.LogError("Migrate [WhatsInTheBag] failed", e);
            }
        }

    }
}
