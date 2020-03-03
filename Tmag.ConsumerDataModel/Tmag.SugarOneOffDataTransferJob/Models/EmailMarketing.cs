using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class EmailMarketing
    {
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string FromName { get; set; }
        public string FromAddr { get; set; }
        public string ReplyToName { get; set; }
        public string ReplyToAddr { get; set; }
        public string InboundEmailId { get; set; }
        public DateTime? DateStart { get; set; }
        public string TemplateId { get; set; }
        public string Status { get; set; }
        public string CampaignId { get; set; }
        public short? AllProspectLists { get; set; }
    }
}
