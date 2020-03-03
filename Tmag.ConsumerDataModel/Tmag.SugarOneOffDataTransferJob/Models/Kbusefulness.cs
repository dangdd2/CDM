using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Kbusefulness
    {
        public string Id { get; set; }
        public string KbarticleId { get; set; }
        public string UserId { get; set; }
        public string ContactId { get; set; }
        public short? Vote { get; set; }
        public short? Zeroflag { get; set; }
        public string Ssid { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
