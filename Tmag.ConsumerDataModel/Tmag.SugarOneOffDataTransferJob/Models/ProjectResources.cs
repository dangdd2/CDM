using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProjectResources
    {
        public string Id { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string ProjectId { get; set; }
        public string ResourceId { get; set; }
        public string ResourceType { get; set; }
        public short? Deleted { get; set; }
    }
}
