﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class AccountsBugs
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string BugId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
