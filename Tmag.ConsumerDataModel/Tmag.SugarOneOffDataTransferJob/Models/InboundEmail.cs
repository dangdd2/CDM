using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class InboundEmail
    {
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string Id { get; set; }
        public short? Deleted { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string ServerUrl { get; set; }
        public string EmailUser { get; set; }
        public string EmailPassword { get; set; }
        public int? Port { get; set; }
        public string Service { get; set; }
        public string Mailbox { get; set; }
        public short? DeleteSeen { get; set; }
        public string MailboxType { get; set; }
        public string TemplateId { get; set; }
        public string StoredOptions { get; set; }
        public string GroupId { get; set; }
        public short? IsPersonal { get; set; }
        public string GroupfolderId { get; set; }
    }
}
