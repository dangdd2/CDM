using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ForecastTree
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string HierarchyType { get; set; }
        public string UserId { get; set; }
        public string ParentId { get; set; }
    }
}
