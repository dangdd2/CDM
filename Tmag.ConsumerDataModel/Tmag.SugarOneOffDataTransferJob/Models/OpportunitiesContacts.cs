using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class OpportunitiesContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string OpportunityId { get; set; }
        public string ContactRole { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
