using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProductBundles
    {
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string BundleStage { get; set; }
        public string Description { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxUsdollar { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalUsdollar { get; set; }
        public decimal? SubtotalUsdollar { get; set; }
        public decimal? ShippingUsdollar { get; set; }
        public decimal? DealTot { get; set; }
        public decimal? DealTotUsdollar { get; set; }
        public decimal? NewSub { get; set; }
        public decimal? NewSubUsdollar { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Shipping { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public string TaxrateId { get; set; }
    }
}
