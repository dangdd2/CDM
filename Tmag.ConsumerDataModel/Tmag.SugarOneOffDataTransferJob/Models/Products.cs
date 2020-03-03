using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Products
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string RevenuelineitemId { get; set; }
        public string ProductTemplateId { get; set; }
        public string AccountId { get; set; }
        public string ContactId { get; set; }
        public decimal? TotalAmount { get; set; }
        public string TypeId { get; set; }
        public string QuoteId { get; set; }
        public string ManufacturerId { get; set; }
        public string CategoryId { get; set; }
        public string MftPartNum { get; set; }
        public string VendorPartNum { get; set; }
        public DateTime? DatePurchased { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountRatePercent { get; set; }
        public decimal? DiscountAmountUsdollar { get; set; }
        public short? DiscountSelect { get; set; }
        public decimal? DealCalc { get; set; }
        public decimal? DealCalcUsdollar { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? CostUsdollar { get; set; }
        public decimal? DiscountUsdollar { get; set; }
        public decimal? ListUsdollar { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public string Status { get; set; }
        public string TaxClass { get; set; }
        public string Website { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Quantity { get; set; }
        public string SupportName { get; set; }
        public string SupportDescription { get; set; }
        public string SupportContact { get; set; }
        public string SupportTerm { get; set; }
        public DateTime? DateSupportExpires { get; set; }
        public DateTime? DateSupportStarts { get; set; }
        public string PricingFormula { get; set; }
        public int? PricingFactor { get; set; }
        public string SerialNumber { get; set; }
        public string AssetNumber { get; set; }
        public decimal? BookValue { get; set; }
        public decimal? BookValueUsdollar { get; set; }
        public DateTime? BookValueDate { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal? DateClosedTimestamp { get; set; }
        public string NextStep { get; set; }
        public string CampaignId { get; set; }
        public string OpportunityId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
