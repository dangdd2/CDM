using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class WorkflowSchedules
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateExpired { get; set; }
        public string WorkflowId { get; set; }
        public string TargetModule { get; set; }
        public string BeanId { get; set; }
        public string Parameters { get; set; }
    }
}
