using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("golfer_profile")]
    public class GolferProfile : Entity
    {
        [Column("golfer_profile_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("consumer_id")]
        public Guid ConsumerId { get; set; }
        [Column("rounds_per_month")]
        public int RoundsPerMonth { get; set; }

        [Column("driver_loft_id")]
        public Guid? DriverLoftId { get; set; }

        [Column("current_driver_flex_id")]
        public Guid? CurrentDriverFlexId { get; set; }

        [Column("current_driver_ball_flight")]
        public string CurrentDriverBallFlight { get; set; }

        [Column("desired_driver_ball_flight")]
        public string DesiredDriverBallFlight { get; set; }

        [Column("typical_driver_distance")]
        public string TypicalDriverDistance { get; set; }

        [Column("current_iron_length_id")]
        public Guid? CurrentIronLengthId { get; set; }

        [Column("current_7iron_ball_flight")]
        public string Current7IronBallFlight { get; set; }

        [Column("desired_7iron_ball_flight")]
        public string Desired7IronBallFlight { get; set; }

        [Column("typical_7iron_distance")]
        public string Typical7IronDistance { get; set; }
        

        [Column("handicap")]
        public int? Handicap { get; set; }

        [Column("club_hand_id")]
        public Guid? ClubHandId { get; set; }

        public virtual Consumer Consumer { get; set; }

        public virtual List<WhatsInTheBag> WhatsInTheBags { get; set; }


        [Column("desired_driver_flex_id")]
        public Guid? DesiredDriverFlexId { get; set; }

        [Column("current_iron_lie_id")]
        public Guid? CurrentIronLieId { get; set; }
        
        [ForeignKey("CurrentIronLengthId")]
        public virtual ClubShaftLength CurrentIronLength { get; set; }
        [ForeignKey("CurrentDriverFlexId")]
        public virtual ClubShaftFlex CurrentDriverFlex { get; set; }
        [ForeignKey("DriverLoftId")]
        public virtual ClubLoft DriverLoft { get; set; }
        [ForeignKey("CurrentIronLieId")]
        public virtual ClubLie CurrentIronLie { get; set; }

        [ForeignKey("DesiredDriverFlexId")]
        public virtual ClubShaftFlex DesiredDriverFlex { get; set; }
        
        public virtual ClubHand ClubHand { get; set; }
    }
}
