using System;

namespace Tmag.ConsumerDataModelApi.TOs
{
    public class ConsumerTo
    {
        public Guid? ConsumerProfileId { get; set; }
        public Guid? ConsumerId { get; set; }
        public Guid? RegionId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameKana { get; set; }
        public string LastNameKana { get; set; }
        public string HandicapRange { get; set; }
        public string Gender { get; set; }
        public Guid? GenderId { get; set; }
        public string Postalcode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneCell { get; set; }
        public string MemberRank { get; set; }
        //public string PhoneBusiness { get; set; }
        public string Description { get; set; }
        public Guid? ClubHandId { get; set; }
        public int? Handicap { get; set; }
        public DateTime? Dob { get; set; }
        public int? Rpm { get; set; }
        public Guid? DriverLoftId { get; set; }
        public Guid? CurrentDriverFlexId { get; set; }
        public string CurrentDriverBallFlight { get; set; }
        public string DesiredDriverBallFlight { get; set; }

        public string TypicalDriverDistance { get; set; }
        public Guid? CurrentIronLengthId { get; set; }
        public Guid? CurrentIronLieId { get; set; }
        public Guid? DesiredDriverFlexId { get; set; }
        public string Current7IronBallFlight { get; set; }
        public string Desired7IronBallFlight { get; set; }
        public string Typical7IronDistance { get; set; }
        public Guid SystemId { get; set; }
    }
}
