﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class WWhatsInTheBag
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string AssignedUserId { get; set; }
        public string Category { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string PlanningToPurchase { get; set; }
    }
}
