using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class WorkflowAlerts
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string FieldValue { get; set; }
        public string RelEmailValue { get; set; }
        public string RelModule1 { get; set; }
        public string RelModule2 { get; set; }
        public string RelModule1Type { get; set; }
        public string RelModule2Type { get; set; }
        public short? WhereFilter { get; set; }
        public string UserType { get; set; }
        public string ArrayType { get; set; }
        public string RelateType { get; set; }
        public string AddressType { get; set; }
        public string ParentId { get; set; }
        public string UserDisplayType { get; set; }
    }
}
