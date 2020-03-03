using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class RecordList
    {
        public string Id { get; set; }
        public string AssignedUserId { get; set; }
        public string ModuleName { get; set; }
        public string Records { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
