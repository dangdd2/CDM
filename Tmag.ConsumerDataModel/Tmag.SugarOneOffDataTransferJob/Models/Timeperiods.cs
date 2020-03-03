using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Timeperiods
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? StartDateTimestamp { get; set; }
        public DateTime? EndDate { get; set; }
        public int? EndDateTimestamp { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public short? IsFiscal { get; set; }
        public short? IsFiscalYear { get; set; }
        public int? LeafCycle { get; set; }
        public string Type { get; set; }
    }
}
