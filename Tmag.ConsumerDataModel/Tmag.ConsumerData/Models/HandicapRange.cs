using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;using System.Text;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("handicap_range")]
    public class HandicapRange : Entity
    {
        [Column("handicap_range_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("range")]
        public string Range { get; set; }
    }
}
