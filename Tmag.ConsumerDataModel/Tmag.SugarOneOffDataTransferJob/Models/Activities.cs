using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Activities
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public short? Deleted { get; set; }
        public string ParentId { get; set; }
        public string ParentType { get; set; }
        public string ActivityType { get; set; }
        public string Data { get; set; }
        public int? CommentCount { get; set; }
        public string LastComment { get; set; }
    }
}
