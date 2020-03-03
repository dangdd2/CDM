using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class OutboundEmail
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string UserId { get; set; }
        public string MailSendtype { get; set; }
        public string MailSmtptype { get; set; }
        public string MailSmtpserver { get; set; }
        public int? MailSmtpport { get; set; }
        public string MailSmtpuser { get; set; }
        public string MailSmtppass { get; set; }
        public short? MailSmtpauthReq { get; set; }
        public int? MailSmtpssl { get; set; }
    }
}
