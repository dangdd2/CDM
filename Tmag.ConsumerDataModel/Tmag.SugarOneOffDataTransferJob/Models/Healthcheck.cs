using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Healthcheck
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string Logfile { get; set; }
        public string Bucket { get; set; }
        public int? Flag { get; set; }
        public byte[] Logmeta { get; set; }
        public string Error { get; set; }
    }
}
