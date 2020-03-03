using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Vcals
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string Content { get; set; }
    }
}
