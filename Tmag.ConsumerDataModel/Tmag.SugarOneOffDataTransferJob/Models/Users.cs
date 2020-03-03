using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Users
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string UserHash { get; set; }
        public short? SystemGeneratedPassword { get; set; }
        public DateTime? PwdLastChanged { get; set; }
        public string AuthenticateId { get; set; }
        public short? SugarLogin { get; set; }
        public string Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public short? IsAdmin { get; set; }
        public short? ExternalAuthOnly { get; set; }
        public short? ReceiveNotifications { get; set; }
        public string Description { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneFax { get; set; }
        public string Status { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalcode { get; set; }
        public string DefaultTeam { get; set; }
        public string TeamSetId { get; set; }
        public short? Deleted { get; set; }
        public short? PortalOnly { get; set; }
        public short? ShowOnEmployees { get; set; }
        public string EmployeeStatus { get; set; }
        public string MessengerId { get; set; }
        public string MessengerType { get; set; }
        public string ReportsToId { get; set; }
        public short? IsGroup { get; set; }
        public string PreferredLanguage { get; set; }
        public string RepCodeC { get; set; }
        public string UserTypeC { get; set; }
        public DateTime? LastLogin { get; set; }
        public string AclRoleSetId { get; set; }
    }
}
