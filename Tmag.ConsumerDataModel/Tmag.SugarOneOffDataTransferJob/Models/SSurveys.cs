using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class SSurveys
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string AssignedUserId { get; set; }
        public string OverallSatisfaction { get; set; }
        public string SurveyLink { get; set; }
    }
}
