using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;


namespace Tmag.ConsumerData.Models
{
    [Table("club_lofts_adjustment")]
    public class ClubLoftAdjustment : Entity
    {
        [Column("club_lofts_adjustment_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("loft_adjustment_value")]
        public string Value { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
        public virtual List<GolferProfile> GolferProfiles { get; set; }        
    }
}
