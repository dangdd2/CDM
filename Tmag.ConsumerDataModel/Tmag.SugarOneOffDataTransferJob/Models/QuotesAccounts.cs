using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class QuotesAccounts
    {
        public string Id { get; set; }
        public string QuoteId { get; set; }
        public string AccountId { get; set; }
        public string AccountRole { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
