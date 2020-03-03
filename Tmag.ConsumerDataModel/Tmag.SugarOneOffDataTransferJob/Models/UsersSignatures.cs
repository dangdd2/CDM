using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class UsersSignatures
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Signature { get; set; }
        public string SignatureHtml { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
    }
}
