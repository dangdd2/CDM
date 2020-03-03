using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Tracker
    {
        public int Id { get; set; }
        public string MonitorId { get; set; }
        public string UserId { get; set; }
        public string ModuleName { get; set; }
        public string ItemId { get; set; }
        public string ItemSummary { get; set; }
        public string TeamId { get; set; }
        public DateTime? DateModified { get; set; }
        public string Action { get; set; }
        public string SessionId { get; set; }
        public short? Visible { get; set; }
        public short? Deleted { get; set; }
    }
}
