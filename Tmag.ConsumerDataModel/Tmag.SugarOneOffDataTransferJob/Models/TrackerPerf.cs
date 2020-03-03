using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TrackerPerf
    {
        public int Id { get; set; }
        public string MonitorId { get; set; }
        public double? ServerResponseTime { get; set; }
        public int? DbRoundTrips { get; set; }
        public int? FilesOpened { get; set; }
        public int? MemoryUsage { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
