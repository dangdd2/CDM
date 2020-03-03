using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Calls
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string ParentType { get; set; }
        public string Status { get; set; }
        public string Direction { get; set; }
        public string ParentId { get; set; }
        public int? ReminderTime { get; set; }
        public int? EmailReminderTime { get; set; }
        public short? EmailReminderSent { get; set; }
        public string OutlookId { get; set; }
        public string RepeatType { get; set; }
        public int? RepeatInterval { get; set; }
        public string RepeatDow { get; set; }
        public DateTime? RepeatUntil { get; set; }
        public int? RepeatCount { get; set; }
        public string RepeatParentId { get; set; }
        public string RecurringSource { get; set; }
        public string RepeatSelector { get; set; }
        public string RepeatDays { get; set; }
        public string RepeatOrdinal { get; set; }
        public string RepeatUnit { get; set; }
        public DateTime? RecurrenceId { get; set; }
    }
}
