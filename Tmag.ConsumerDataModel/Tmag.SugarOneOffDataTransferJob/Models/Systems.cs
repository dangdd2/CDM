using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Systems
    {
        public string Id { get; set; }
        public int SystemId { get; set; }
        public string SystemKey { get; set; }
        public string UserId { get; set; }
        public DateTime? LastConnectDate { get; set; }
        public string Status { get; set; }
        public int? NumSyncs { get; set; }
        public string SystemName { get; set; }
        public string InstallMethod { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
