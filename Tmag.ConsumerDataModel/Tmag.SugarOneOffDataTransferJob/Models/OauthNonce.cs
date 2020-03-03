using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class OauthNonce
    {
        public string Conskey { get; set; }
        public string Nonce { get; set; }
        public long? NonceTs { get; set; }
    }
}
