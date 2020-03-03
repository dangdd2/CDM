using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TrackerTrackerQueries
    {
        public int Id { get; set; }
        public string MonitorId { get; set; }
        public string QueryId { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
