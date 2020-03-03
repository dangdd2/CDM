using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("club_lofts")]
    public class ClubLoft : Entity
    {
        [Column("club_loft_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("loft_value")]
        public string Value { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
        [Column("club_category_id")]
        public Guid? ClubCategoryId { get; set; }
        public ClubCategory ClubCategory { get; set; }
        public virtual List<GolferProfile> GolferProfiles { get; set; }       
    }
}
