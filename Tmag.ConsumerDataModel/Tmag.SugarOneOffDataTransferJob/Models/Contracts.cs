using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Contracts
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string ReferenceCode { get; set; }
        public string AccountId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public decimal? TotalContractValue { get; set; }
        public decimal? TotalContractValueUsdollar { get; set; }
        public string Status { get; set; }
        public DateTime? CustomerSignedDate { get; set; }
        public DateTime? CompanySignedDate { get; set; }
        public DateTime? ExpirationNotice { get; set; }
        public string Type { get; set; }
    }
}
