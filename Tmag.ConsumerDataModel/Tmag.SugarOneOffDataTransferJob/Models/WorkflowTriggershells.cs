using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class WorkflowTriggershells
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Field { get; set; }
        public string Type { get; set; }
        public string FrameType { get; set; }
        public string Eval { get; set; }
        public string ParentId { get; set; }
        public short? ShowPast { get; set; }
        public string RelModule { get; set; }
        public string RelModuleType { get; set; }
        public string Parameters { get; set; }
    }
}
