using System;

namespace Tmag.ConsumerDataModelApi.TOs
{
    public class BagPanelTo
    {
        public Guid RegionId { get; set; }
        public string ItemNumber { get; set; }
        public Guid BagModelId { get; set; }
        public string BagColor { get; set; }
        public Guid FontId { get; set; }
        public string TextLine1 { get; set; }
        public string TextLine2 { get; set; }
        public string TextLine3 { get; set; }
        public string Sku { get; set; }
        public int Handicap { get; set; }
        public int RoundsPerMonth { get; set; }
        public Guid PointOfPurchaseId { get; set; }
        public string BagUsage { get; set; }
        public string BagTopQuality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string OptInBrand { get; set; }
        

    }
}
