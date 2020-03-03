using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProductBundleNote
    {
        public string Id { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string BundleId { get; set; }
        public string NoteId { get; set; }
        public int? NoteIndex { get; set; }
    }
}
