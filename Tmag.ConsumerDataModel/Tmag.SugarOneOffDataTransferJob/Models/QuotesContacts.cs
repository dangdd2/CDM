﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class QuotesContacts
    {
        public string Id { get; set; }
        public string ContactId { get; set; }
        public string QuoteId { get; set; }
        public string ContactRole { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
