using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Kbcontents
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string KbdocumentBody { get; set; }
        public string Language { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public short? Approved { get; set; }
        public string Status { get; set; }
        public int? Viewcount { get; set; }
        public int? Revision { get; set; }
        public int? Useful { get; set; }
        public int? Notuseful { get; set; }
        public string KbdocumentId { get; set; }
        public short? ActiveRev { get; set; }
        public short? IsExternal { get; set; }
        public string KbarticleId { get; set; }
        public string KbsapproverId { get; set; }
        public string KbscaseId { get; set; }
        public string CategoryId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string AssignedUserId { get; set; }
    }
}
