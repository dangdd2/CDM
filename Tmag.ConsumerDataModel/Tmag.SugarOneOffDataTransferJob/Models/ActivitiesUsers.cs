using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ActivitiesUsers
    {
        public string Id { get; set; }
        public string ActivityId { get; set; }
        public string ParentType { get; set; }
        public string ParentId { get; set; }
        public string Fields { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
