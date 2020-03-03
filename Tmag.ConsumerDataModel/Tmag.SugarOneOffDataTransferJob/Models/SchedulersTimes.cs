using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class SchedulersTimes
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string SchedulerId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public string Status { get; set; }
    }
}
