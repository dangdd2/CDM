using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class FoldersSubscriptions
    {
        public string Id { get; set; }
        public string FolderId { get; set; }
        public string AssignedUserId { get; set; }
    }
}
