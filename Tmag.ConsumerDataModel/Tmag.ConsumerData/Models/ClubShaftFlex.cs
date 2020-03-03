using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("club_shaft_flexs")]
    public class ClubShaftFlex : Entity
    {
        [Column("club_shaft_flex_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("flex_value")]
        public string Value { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
