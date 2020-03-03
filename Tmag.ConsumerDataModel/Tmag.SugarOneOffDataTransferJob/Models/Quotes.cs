using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Quotes
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
        public string ShipperId { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public string TaxrateId { get; set; }
        public short? ShowLineNums { get; set; }
        public short? CalcGrandTotal { get; set; }
        public string QuoteType { get; set; }
        public DateTime? DateQuoteExpectedClosed { get; set; }
        public DateTime? OriginalPoDate { get; set; }
        public string PaymentTerms { get; set; }
        public DateTime? DateQuoteClosed { get; set; }
        public DateTime? DateOrderShipped { get; set; }
        public string OrderStage { get; set; }
        public string QuoteStage { get; set; }
        public string PurchaseOrderNum { get; set; }
        public int QuoteNum { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? SubtotalUsdollar { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? ShippingUsdollar { get; set; }
        public decimal? Discount { get; set; }
        public decimal? DealTot { get; set; }
        public decimal? DealTotUsdollar { get; set; }
        public decimal? NewSub { get; set; }
        public decimal? NewSubUsdollar { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxUsdollar { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalUsdollar { get; set; }
        public string BillingAddressStreet { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressPostalcode { get; set; }
        public string BillingAddressCountry { get; set; }
        public string ShippingAddressStreet { get; set; }
        public string ShippingAddressCity { get; set; }
        public string ShippingAddressState { get; set; }
        public string ShippingAddressPostalcode { get; set; }
        public string ShippingAddressCountry { get; set; }
        public int? SystemId { get; set; }
    }
}
