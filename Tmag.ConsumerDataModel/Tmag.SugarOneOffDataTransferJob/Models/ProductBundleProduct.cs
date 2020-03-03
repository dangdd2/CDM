using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProductBundleProduct
    {
        public string Id { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string BundleId { get; set; }
        public string ProductId { get; set; }
        public int? ProductIndex { get; set; }
    }
}
