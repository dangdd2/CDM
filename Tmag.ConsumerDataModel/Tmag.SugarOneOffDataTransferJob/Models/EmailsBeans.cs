using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class EmailsBeans
    {
        public string Id { get; set; }
        public string EmailId { get; set; }
        public string BeanId { get; set; }
        public string BeanModule { get; set; }
        public string CampaignData { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
