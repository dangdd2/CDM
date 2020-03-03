using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ForecastWorksheets
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
        public string ParentId { get; set; }
        public string ParentType { get; set; }
        public string OpportunityId { get; set; }
        public string OpportunityName { get; set; }
        public string AccountName { get; set; }
        public string AccountId { get; set; }
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string ProductTemplateId { get; set; }
        public string ProductTemplateName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SalesStatus { get; set; }
        public decimal? LikelyCase { get; set; }
        public decimal? BestCase { get; set; }
        public decimal? WorstCase { get; set; }
        public decimal? BaseRate { get; set; }
        public string CurrencyId { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal? DateClosedTimestamp { get; set; }
        public string SalesStage { get; set; }
        public double? Probability { get; set; }
        public string CommitStage { get; set; }
        public int? Draft { get; set; }
        public string NextStep { get; set; }
        public string LeadSource { get; set; }
        public string ProductType { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
