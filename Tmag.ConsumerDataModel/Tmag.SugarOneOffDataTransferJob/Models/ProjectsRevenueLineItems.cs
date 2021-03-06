﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProjectsRevenueLineItems
    {
        public string Id { get; set; }
        public string RliId { get; set; }
        public string ProjectId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
