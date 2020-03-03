using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProductTemplates
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string TypeId { get; set; }
        public string ManufacturerId { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public string MftPartNum { get; set; }
        public string VendorPartNum { get; set; }
        public DateTime? DateCostPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? CostUsdollar { get; set; }
        public decimal? DiscountUsdollar { get; set; }
        public decimal? ListUsdollar { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string TaxClass { get; set; }
        public DateTime? DateAvailable { get; set; }
        public string Website { get; set; }
        public decimal? Weight { get; set; }
        public int? QtyInStock { get; set; }
        public string Description { get; set; }
        public string SupportName { get; set; }
        public string SupportDescription { get; set; }
        public string SupportContact { get; set; }
        public string SupportTerm { get; set; }
        public string PricingFormula { get; set; }
        public decimal? PricingFactor { get; set; }
        public string AssignedUserId { get; set; }
    }
}
