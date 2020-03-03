using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("club_category_types")]
    public class ClubCategoryType : Entity
    {
        [Column("club_category_types_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("club_category_id")]
        public  Guid ClubCategoryId { get; set; }

        [Column("category_type")]
        public string Type { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
        public virtual ClubCategory ClubCategory { get; set; }
    }
}
