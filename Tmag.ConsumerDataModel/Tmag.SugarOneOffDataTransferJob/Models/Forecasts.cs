using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Forecasts
    {
        public string Id { get; set; }
        public string TimeperiodId { get; set; }
        public string ForecastType { get; set; }
        public int? OppCount { get; set; }
        public int? PipelineOppCount { get; set; }
        public decimal? PipelineAmount { get; set; }
        public decimal? ClosedAmount { get; set; }
        public int? OppWeighValue { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public decimal? BestCase { get; set; }
        public decimal? LikelyCase { get; set; }
        public decimal? WorstCase { get; set; }
        public string UserId { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
