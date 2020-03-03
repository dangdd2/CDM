using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class DocumentRevisions
    {
        public string Id { get; set; }
        public string ChangeLog { get; set; }
        public string DocumentId { get; set; }
        public string DocId { get; set; }
        public string DocType { get; set; }
        public string DocUrl { get; set; }
        public DateTime? DateEntered { get; set; }
        public string CreatedBy { get; set; }
        public string Filename { get; set; }
        public string FileExt { get; set; }
        public string FileMimeType { get; set; }
        public string Revision { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
