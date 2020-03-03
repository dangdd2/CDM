using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ForecastSchedule
    {
        public string Id { get; set; }
        public string TimeperiodId { get; set; }
        public string UserId { get; set; }
        public short? CascadeHierarchy { get; set; }
        public DateTime? ForecastStartDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
