using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class AclRolesUsers
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string UserId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
