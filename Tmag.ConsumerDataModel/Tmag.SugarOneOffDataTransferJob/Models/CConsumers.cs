using System;
using System.Collections.Generic;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class CConsumers
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
        public string Email { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Optout { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalcode { get; set; }
        public string AddressCountry { get; set; }
        public DateTime? Dob { get; set; }
        public string HandicapRange { get; set; }
        public string Rpm { get; set; }
        public string Dexterity { get; set; }
        public string Gender { get; set; }
        public string Whereplay { get; set; }
        public string Yearsplay { get; set; }
        public string Height { get; set; }
        public string Phonehm { get; set; }
        public string Phonemb { get; set; }
        public int? ResponsysId { get; set; }
        public short? Responsys { get; set; }
        public DateTime? ResponsysDate { get; set; }
        public short? Tmag { get; set; }
        public short? Adidas { get; set; }
        public short? Ashworth { get; set; }
        public short? Adams { get; set; }
        public short? Outlet { get; set; }
        public string Euci { get; set; }
        public string Instagramid { get; set; }
        public string Linkedinid { get; set; }
        public string Twitterhandle { get; set; }
        public string Facebookid { get; set; }
        public string ExternalMarketingSegment { get; set; }
        public string InternalMarketingSegment { get; set; }

        public virtual List<EExperiencesCConsumersC> CConsumer { get; set; }
    }
}
