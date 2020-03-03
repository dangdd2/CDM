using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Opportunities
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
        public string OpportunityType { get; set; }
        public string CampaignId { get; set; }
        public string LeadSource { get; set; }
        public decimal? Amount { get; set; }
        public decimal? BaseRate { get; set; }
        public decimal? AmountUsdollar { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal? DateClosedTimestamp { get; set; }
        public string NextStep { get; set; }
        public string SalesStage { get; set; }
        public string SalesStatus { get; set; }
        public double? Probability { get; set; }
        public decimal? BestCase { get; set; }
        public decimal? WorstCase { get; set; }
        public string CommitStage { get; set; }
        public short? MktoSync { get; set; }
        public int? MktoId { get; set; }
    }
}
