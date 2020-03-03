using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ContractTypes
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? ListOrder { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public short? Deleted { get; set; }
    }
}
