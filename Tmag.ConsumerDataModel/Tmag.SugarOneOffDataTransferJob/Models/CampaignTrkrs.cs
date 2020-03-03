using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class CampaignTrkrs
    {
        public string Id { get; set; }
        public string TrackerName { get; set; }
        public string TrackerUrl { get; set; }
        public int TrackerKey { get; set; }
        public string CampaignId { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public short? IsOptout { get; set; }
        public short? Deleted { get; set; }
    }
}
