using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TeamSetsTeams
    {
        public string Id { get; set; }
        public string TeamSetId { get; set; }
        public string TeamId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
