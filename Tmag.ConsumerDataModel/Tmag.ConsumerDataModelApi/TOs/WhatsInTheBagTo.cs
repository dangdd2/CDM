using System;

namespace Tmag.ConsumerDataModelApi.TOs
{
    public class WhatsInTheBagTo
    {
        public bool Favorite { get; set; }
        public bool Following { get; set; }
        public Guid Id { get; set; }
        public string UserFavorites { get; set; }
        public string Description { get; set; }
        public DateTime? Deleted { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public Guid ModelId { get; set; }
        public bool PlanningToPurchase { get; set; }
        public Guid? ConsumerId { get; set; }
        public string Sku { get; set; }
        public Guid? ClubLoftId { get; set; }
        public Guid? ClubShaftFlexId { get; set; }
        public Guid? ClubShaftLengthId { get; set; }
        public Guid? FaceLieAdjustmentId { get; set; }
        public Guid? FaceLoftAdjustmentId { get; set; }
        public Guid? ClubCategoryTypeId { get; set; }
        public bool Active { get; set; }
    }
}
