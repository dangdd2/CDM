using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class JobQueue
    {
        public string AssignedUserId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string SchedulerId { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
        public string Message { get; set; }
        public string Target { get; set; }
        public string Data { get; set; }
        public short? Requeue { get; set; }
        public short? RetryCount { get; set; }
        public short? FailureCount { get; set; }
        public int? JobDelay { get; set; }
        public string Client { get; set; }
        public int? PercentComplete { get; set; }
        public string JobGroup { get; set; }
        public string Module { get; set; }
        public short? Fallible { get; set; }
        public short? Rerun { get; set; }
        public short? Interface { get; set; }
    }
}
