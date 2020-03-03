using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class SavedReports
    {
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
        public string ReportType { get; set; }
        public string Content { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string AssignedUserId { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public short? IsPublished { get; set; }
        public string ChartType { get; set; }
        public string ScheduleType { get; set; }
        public short? Favorite { get; set; }
    }
}
