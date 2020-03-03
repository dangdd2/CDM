using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TrackerQueries
    {
        public int Id { get; set; }
        public string QueryId { get; set; }
        public string Text { get; set; }
        public string QueryHash { get; set; }
        public double? SecTotal { get; set; }
        public double? SecAvg { get; set; }
        public int? RunCount { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
