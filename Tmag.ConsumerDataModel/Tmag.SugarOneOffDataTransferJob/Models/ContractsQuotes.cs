using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ContractsQuotes
    {
        public string Id { get; set; }
        public string QuoteId { get; set; }
        public string ContractId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
