using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProspectListsProspects
    {
        public string Id { get; set; }
        public string ProspectListId { get; set; }
        public string RelatedId { get; set; }
        public string RelatedType { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
