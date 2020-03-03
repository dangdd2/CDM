using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class WorkflowAlertshells
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string AlertText { get; set; }
        public string AlertType { get; set; }
        public string SourceType { get; set; }
        public string ParentId { get; set; }
        public string CustomTemplateId { get; set; }
    }
}
