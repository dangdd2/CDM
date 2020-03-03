using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class TagBeanRel
    {
        public string Id { get; set; }
        public string TagId { get; set; }
        public string BeanId { get; set; }
        public string BeanModule { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
