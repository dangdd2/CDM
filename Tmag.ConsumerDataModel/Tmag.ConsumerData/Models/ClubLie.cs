using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("club_lies")]
    public class ClubLie : Entity
    {
        [Column("club_lie_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("lie_value")]
        public string Value { get; set; }
        [Column("sort_order")]
        public int SortOrder { get; set; }        
    }
}
