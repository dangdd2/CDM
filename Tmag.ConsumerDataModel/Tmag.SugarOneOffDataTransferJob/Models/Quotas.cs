using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Quotas
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string TimeperiodId { get; set; }
        public string QuotaType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountBaseCurrency { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public short? Committed { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AssignedUserId { get; set; }
    }
}
