using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class AclRoleSetsAclRoles
    {
        public string Id { get; set; }
        public string AclRoleSetId { get; set; }
        public string AclRoleId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
