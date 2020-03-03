using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Holidays
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? HolidayDate { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string PersonId { get; set; }
        public string PersonType { get; set; }
        public string RelatedModule { get; set; }
        public string RelatedModuleId { get; set; }
        public string ResourceName { get; set; }
    }
}
