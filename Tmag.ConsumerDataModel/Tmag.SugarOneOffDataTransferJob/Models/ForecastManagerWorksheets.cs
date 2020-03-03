using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ForecastManagerWorksheets
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public decimal? Quota { get; set; }
        public decimal? BestCase { get; set; }
        public decimal? BestCaseAdjusted { get; set; }
        public decimal? LikelyCase { get; set; }
        public decimal? LikelyCaseAdjusted { get; set; }
        public decimal? WorstCase { get; set; }
        public decimal? WorstCaseAdjusted { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public string TimeperiodId { get; set; }
        public short? Draft { get; set; }
        public string UserId { get; set; }
        public int? OppCount { get; set; }
        public int? PipelineOppCount { get; set; }
        public decimal? PipelineAmount { get; set; }
        public decimal? ClosedAmount { get; set; }
        public short? ManagerSaved { get; set; }
    }
}
