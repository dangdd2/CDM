using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ContractsProducts
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string ContractId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
