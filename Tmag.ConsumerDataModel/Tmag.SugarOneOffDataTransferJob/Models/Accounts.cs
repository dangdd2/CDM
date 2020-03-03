using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Accounts
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
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Googleplus { get; set; }
        public string AccountType { get; set; }
        public string Industry { get; set; }
        public string AnnualRevenue { get; set; }
        public string PhoneFax { get; set; }
        public string BillingAddressStreet { get; set; }
        public string BillingAddressCity { get; set; }
        public string BillingAddressState { get; set; }
        public string BillingAddressPostalcode { get; set; }
        public string BillingAddressCountry { get; set; }
        public string Rating { get; set; }
        public string PhoneOffice { get; set; }
        public string PhoneAlternate { get; set; }
        public string Website { get; set; }
        public string Ownership { get; set; }
        public string Employees { get; set; }
        public string TickerSymbol { get; set; }
        public string ShippingAddressStreet { get; set; }
        public string ShippingAddressCity { get; set; }
        public string ShippingAddressState { get; set; }
        public string ShippingAddressPostalcode { get; set; }
        public string ShippingAddressCountry { get; set; }
        public string ParentId { get; set; }
        public string SicCode { get; set; }
        public string DunsNum { get; set; }
        public string CampaignId { get; set; }
        public string ShiptoIdC { get; set; }
        public string BilltoIdC { get; set; }
    }
}
