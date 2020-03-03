using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TeamSets
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TeamMd5 { get; set; }
        public int? TeamCount { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string CreatedBy { get; set; }
    }
}
