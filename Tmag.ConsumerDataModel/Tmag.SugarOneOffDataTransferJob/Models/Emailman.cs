using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Emailman
    {
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserId { get; set; }
        public int Id { get; set; }
        public string CampaignId { get; set; }
        public string MarketingId { get; set; }
        public string ListId { get; set; }
        public DateTime? SendDateTime { get; set; }
        public string ModifiedUserId { get; set; }
        public short? InQueue { get; set; }
        public DateTime? InQueueDate { get; set; }
        public int? SendAttempts { get; set; }
        public short? Deleted { get; set; }
        public string RelatedId { get; set; }
        public string RelatedType { get; set; }
    }
}
