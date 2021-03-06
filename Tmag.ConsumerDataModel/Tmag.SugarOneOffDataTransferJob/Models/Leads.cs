﻿using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class Leads
    {
        public string Id { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedUserId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public short? Deleted { get; set; }
        public string AssignedUserId { get; set; }
        public string TeamId { get; set; }
        public string TeamSetId { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Googleplus { get; set; }
        public string Department { get; set; }
        public short? DoNotCall { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneFax { get; set; }
        public string PrimaryAddressStreet { get; set; }
        public string PrimaryAddressCity { get; set; }
        public string PrimaryAddressState { get; set; }
        public string PrimaryAddressPostalcode { get; set; }
        public string PrimaryAddressCountry { get; set; }
        public string AltAddressStreet { get; set; }
        public string AltAddressCity { get; set; }
        public string AltAddressState { get; set; }
        public string AltAddressPostalcode { get; set; }
        public string AltAddressCountry { get; set; }
        public string Assistant { get; set; }
        public string AssistantPhone { get; set; }
        public string Picture { get; set; }
        public short? Converted { get; set; }
        public string ReferedBy { get; set; }
        public string LeadSource { get; set; }
        public string LeadSourceDescription { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public string ReportsToId { get; set; }
        public string AccountName { get; set; }
        public string AccountDescription { get; set; }
        public string ContactId { get; set; }
        public string AccountId { get; set; }
        public string OpportunityId { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityAmount { get; set; }
        public string CampaignId { get; set; }
        public DateTime? Birthdate { get; set; }
        public string PortalName { get; set; }
        public string PortalApp { get; set; }
        public string Website { get; set; }
        public string PreferredLanguage { get; set; }
        public short? MktoSync { get; set; }
        public int? MktoId { get; set; }
        public int? MktoLeadScore { get; set; }
        public string DnbPrincipalId { get; set; }
    }
}
