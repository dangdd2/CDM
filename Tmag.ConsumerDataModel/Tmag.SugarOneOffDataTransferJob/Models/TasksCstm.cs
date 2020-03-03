using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TasksCstm
    {
        public string IdC { get; set; }
        public DateTime? CompletedDateC { get; set; }
        public int? TaskCycleTimeC { get; set; }
        public string UkAccountNameC { get; set; }
        public string UkCaseNotesC { get; set; }
        public string UkReferenceNumberC { get; set; }
        public string UkTaskTypeC { get; set; }
        public string UkTrackingNumberC { get; set; }
        public string UkWarehouseC { get; set; }
        public string UkWorkLogC { get; set; }
        public string UnassignedC { get; set; }
        public string UserTypeC { get; set; }
    }
}
