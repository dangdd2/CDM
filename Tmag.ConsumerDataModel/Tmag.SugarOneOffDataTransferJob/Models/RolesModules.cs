using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class RolesModules
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string ModuleId { get; set; }
        public short? Allow { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
