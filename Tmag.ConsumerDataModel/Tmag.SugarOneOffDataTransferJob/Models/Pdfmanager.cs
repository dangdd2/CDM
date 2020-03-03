using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Pdfmanager
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string AssignedUserId { get; set; }
        public string BaseModule { get; set; }
        public string Published { get; set; }
        public string Field { get; set; }
        public string BodyHtml { get; set; }
        public string TemplateName { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Keywords { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderText { get; set; }
        public string FooterText { get; set; }
        public string HeaderLogo { get; set; }
    }
}
