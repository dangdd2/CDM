using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class CategoryTree
    {
        public string SelfId { get; set; }
        public int NodeId { get; set; }
        public int? ParentNodeId { get; set; }
        public string Type { get; set; }
    }
}
