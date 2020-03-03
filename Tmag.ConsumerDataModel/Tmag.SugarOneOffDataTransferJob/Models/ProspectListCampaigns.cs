using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProspectListCampaigns
    {
        public string Id { get; set; }
        public string ProspectListId { get; set; }
        public string CampaignId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
