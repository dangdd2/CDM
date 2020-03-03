using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ReportCache
    {
        public string Id { get; set; }
        public string AssignedUserId { get; set; }
        public string Contents { get; set; }
        public string ReportOptions { get; set; }
        public string Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
