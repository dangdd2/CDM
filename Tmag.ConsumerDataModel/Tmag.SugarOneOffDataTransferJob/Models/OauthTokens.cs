using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class OauthTokens
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        public string Tstate { get; set; }
        public string Consumer { get; set; }
        public long? TokenTs { get; set; }
        public long? ExpireTs { get; set; }
        public string Verify { get; set; }
        public string DownloadToken { get; set; }
        public string Platform { get; set; }
        public short Deleted { get; set; }
        public string CallbackUrl { get; set; }
        public string ContactId { get; set; }
        public string AssignedUserId { get; set; }
    }
}
