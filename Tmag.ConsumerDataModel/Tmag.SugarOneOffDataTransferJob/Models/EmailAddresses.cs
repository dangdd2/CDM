using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class EmailAddresses
    {
        public string Id { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddressCaps { get; set; }
        public short? InvalidEmail { get; set; }
        public short? OptOut { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
