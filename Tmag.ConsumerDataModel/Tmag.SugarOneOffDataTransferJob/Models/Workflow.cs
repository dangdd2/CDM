using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Workflow
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string BaseModule { get; set; }
        public short? Status { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string FireOrder { get; set; }
        public string ParentId { get; set; }
        public string RecordType { get; set; }
        public int? ListOrderY { get; set; }
    }
}
