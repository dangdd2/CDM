using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class AccountsContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string AccountId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? PrimaryAccount { get; set; }
        public short? Deleted { get; set; }
    }
}
