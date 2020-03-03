using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ReportSchedules
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ReportId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? NextRun { get; set; }
        public short? Active { get; set; }
        public int? TimeInterval { get; set; }
        public DateTime? DateModified { get; set; }
        public string ScheduleType { get; set; }
        public short? Deleted { get; set; }
    }
}
