using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Categories
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string Root { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public int Lvl { get; set; }
        public short? IsExternal { get; set; }
        public string SourceId { get; set; }
        public string SourceType { get; set; }
        public string SourceMeta { get; set; }
    }
}
