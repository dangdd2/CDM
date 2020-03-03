using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class MetadataCache
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public byte[] Data { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
