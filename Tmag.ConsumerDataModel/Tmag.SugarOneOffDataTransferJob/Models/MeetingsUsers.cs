﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class MeetingsUsers
    {
        public string Id { get; set; }
        public string MeetingId { get; set; }
        public string UserId { get; set; }
        public string Required { get; set; }
        public string AcceptStatus { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
