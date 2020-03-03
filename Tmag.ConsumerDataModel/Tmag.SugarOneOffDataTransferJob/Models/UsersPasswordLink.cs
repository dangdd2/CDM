using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class UsersPasswordLink
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public DateTime? DateGenerated { get; set; }
        public short? Deleted { get; set; }
    }
}
