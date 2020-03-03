using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Documents
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string DocumentName { get; set; }
        public string DocId { get; set; }
        public string DocType { get; set; }
        public string DocUrl { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string CategoryId { get; set; }
        public string SubcategoryId { get; set; }
        public string StatusId { get; set; }
        public string DocumentRevisionId { get; set; }
        public string RelatedDocId { get; set; }
        public string RelatedDocRevId { get; set; }
        public short? IsTemplate { get; set; }
        public string TemplateType { get; set; }
    }
}
