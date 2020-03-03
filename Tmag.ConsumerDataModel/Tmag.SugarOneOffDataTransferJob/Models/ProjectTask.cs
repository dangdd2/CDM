using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class ProjectTask
    {
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ProjectId { get; set; }
        public int? ProjectTaskId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ResourceId { get; set; }
        public string Predecessors { get; set; }
        public DateTime? DateStart { get; set; }
        public int? TimeStart { get; set; }
        public int? TimeFinish { get; set; }
        public DateTime? DateFinish { get; set; }
        public int? Duration { get; set; }
        public string DurationUnit { get; set; }
        public int? ActualDuration { get; set; }
        public int? PercentComplete { get; set; }
        public DateTime? DateDue { get; set; }
        public TimeSpan? TimeDue { get; set; }
        public int? ParentTaskId { get; set; }
        public string AssignedUserId { get; set; }
        public string ModifiedUserId { get; set; }
        public string Priority { get; set; }
        public string CreatedBy { get; set; }
        public short? MilestoneFlag { get; set; }
        public int? OrderNumber { get; set; }
        public int? TaskNumber { get; set; }
        public int? EstimatedEffort { get; set; }
        public int? ActualEffort { get; set; }
        public short? Deleted { get; set; }
        public int? Utilization { get; set; }
    }
}
