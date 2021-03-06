﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class AccountsOpportunities
    {
        public string Id { get; set; }
        public string OpportunityId { get; set; }
        public string AccountId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
