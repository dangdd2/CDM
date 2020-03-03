using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class EmailAddrBeanRel
    {
        public string Id { get; set; }
        public string EmailAddressId { get; set; }
        public string BeanId { get; set; }
        public string BeanModule { get; set; }
        public short? PrimaryAddress { get; set; }
        public short? ReplyToAddress { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
