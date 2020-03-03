﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class DocumentsContacts
    {
        public string Id { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string DocumentId { get; set; }
        public string ContactId { get; set; }
    }
}
