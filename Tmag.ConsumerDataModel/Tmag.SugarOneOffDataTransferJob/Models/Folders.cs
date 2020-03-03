using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Folders
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string FolderType { get; set; }
        public string ParentFolder { get; set; }
        public short? HasChild { get; set; }
        public short? IsGroup { get; set; }
        public short? IsDynamic { get; set; }
        public string DynamicQuery { get; set; }
        public string AssignToId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public short? Deleted { get; set; }
    }
}
