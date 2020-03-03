using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class UkCases
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
        public int UkCasesNumber { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Resolution { get; set; }
        public int? SystemId { get; set; }
        public string WorkLog { get; set; }
        public int? CaseAge { get; set; }
        public string CustomerType { get; set; }
        public DateTime? DateClosed { get; set; }
        public string ShiptoId { get; set; }
        public int? TotalCycleTime { get; set; }
        public decimal? Amount { get; set; }
        public string CurrencyId { get; set; }
        public decimal? BaseRate { get; set; }
        public string Brand { get; set; }
        public string Carrier { get; set; }
        public string CaseType { get; set; }
        public string ContactName { get; set; }
        public string EmailAddress { get; set; }
        public string OtherDescription { get; set; }
        public string ParcelPalletCount { get; set; }
        public string ProductCategory { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public string SubType { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingUrl { get; set; }
        public short? VasAccount { get; set; }
        public string Warehouse { get; set; }
        public string WorkflowCurrency { get; set; }
    }
}
