using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Campaigns
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public int TrackerKey { get; set; }
        public int? TrackerCount { get; set; }
        public string ReferUrl { get; set; }
        public string TrackerText { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public int? Impressions { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public decimal? Budget { get; set; }
        public decimal? ExpectedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public decimal? ExpectedRevenue { get; set; }
        public string CampaignType { get; set; }
        public string Objective { get; set; }
        public string Content { get; set; }
        public string Frequency { get; set; }
    }
}
