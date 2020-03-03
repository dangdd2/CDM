using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("club_hand")]
    public class ClubHand : Entity
    {
        [Column("club_hand_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("club_hand_desc")]
        public string Description { get; set; }
        public virtual List<GolferProfile> GolferProfiles { get; set; }
    }
}
