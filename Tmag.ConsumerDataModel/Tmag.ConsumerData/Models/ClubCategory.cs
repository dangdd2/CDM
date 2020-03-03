using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("club_categories")]
    public class ClubCategory : Entity
    {
        [Column("club_category_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("category_name")]
        public string Name { get; set; }
        
        public virtual List<ClubCategoryType> ClubCategoryTypes { get; set; }
        public virtual List<ClubLie> ClubLies { get; set; }
        public virtual List<Brand> Brands { get; set; }
    }
}
