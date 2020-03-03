using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TeamSetsModules
    {
        public string Id { get; set; }
        public string TeamSetId { get; set; }
        public string ModuleTableName { get; set; }
        public short? Deleted { get; set; }
    }
}
