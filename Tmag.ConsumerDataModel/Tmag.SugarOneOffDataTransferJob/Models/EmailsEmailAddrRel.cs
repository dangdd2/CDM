using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class EmailsEmailAddrRel
    {
        public string Id { get; set; }
        public string EmailId { get; set; }
        public string AddressType { get; set; }
        public string EmailAddressId { get; set; }
        public short? Deleted { get; set; }
    }
}
