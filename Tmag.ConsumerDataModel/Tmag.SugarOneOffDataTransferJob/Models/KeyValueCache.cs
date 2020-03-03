using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class KeyValueCache
    {
        public string Id { get; set; }
        public DateTime? DateExpires { get; set; }
        public string Value { get; set; }
    }
}
