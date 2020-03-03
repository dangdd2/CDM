using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("brands")]
    public class Brand : Entity
    {
        [Column("brand_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("brand_name")]
        public string Name { get; set; }
        [Column("club_category_id")]
        public Guid? ClubCategoryId { get; set; }
        
        public virtual List<Model> Models { get; set; }
    }
}
