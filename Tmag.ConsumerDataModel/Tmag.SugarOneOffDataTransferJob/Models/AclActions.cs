﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class AclActions
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Acltype { get; set; }
        public int? Aclaccess { get; set; }
        public short? Deleted { get; set; }
    }
}
