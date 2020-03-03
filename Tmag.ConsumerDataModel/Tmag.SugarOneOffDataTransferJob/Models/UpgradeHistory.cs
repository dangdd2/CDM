using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class UpgradeHistory
    {
        public string Id { get; set; }
        public string Filename { get; set; }
        public string Md5sum { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IdName { get; set; }
        public string Manifest { get; set; }
        public DateTime? DateEntered { get; set; }
        public short? Enabled { get; set; }
        public string Patch { get; set; }
    }
}
