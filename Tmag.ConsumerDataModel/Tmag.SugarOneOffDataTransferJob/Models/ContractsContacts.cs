using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ContractsContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string ContractId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
