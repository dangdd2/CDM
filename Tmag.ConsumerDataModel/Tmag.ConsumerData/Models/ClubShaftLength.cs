using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;


namespace Tmag.ConsumerData.Models
{
    [Table("club_shaft_lengths")]
    public class ClubShaftLength : Entity
    {
        [Column("club_shaft_length_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("length_value")]
        public string Value { get; set; }
        [Column("is_minor_adjustment")]
        public bool IsMinorAdjustment { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
        public virtual List<GolferProfile> GolferProfiles { get; set; }
      
    }
}
