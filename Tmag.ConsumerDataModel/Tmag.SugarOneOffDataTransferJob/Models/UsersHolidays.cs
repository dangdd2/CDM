using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class UsersHolidays
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string HolidayId { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
    }
}
