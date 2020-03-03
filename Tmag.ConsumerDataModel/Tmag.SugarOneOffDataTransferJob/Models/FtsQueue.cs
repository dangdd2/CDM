using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class FtsQueue
    {
        public string Id { get; set; }
        public string BeanId { get; set; }
        public string BeanModule { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCreated { get; set; }
        public short? Processed { get; set; }
    }
}
