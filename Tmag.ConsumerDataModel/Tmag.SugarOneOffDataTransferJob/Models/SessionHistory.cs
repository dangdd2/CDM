using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class SessionHistory
    {
        public string Id { get; set; }
        public string SessionId { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? LastRequestTime { get; set; }
        public string SessionType { get; set; }
        public short? IsViolation { get; set; }
        public int? NumActiveSessions { get; set; }
        public short? Deleted { get; set; }
    }
}
