using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TrackerSessions
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? Seconds { get; set; }
        public string ClientIp { get; set; }
        public string UserId { get; set; }
        public short? Active { get; set; }
        public short? Deleted { get; set; }
    }
}
