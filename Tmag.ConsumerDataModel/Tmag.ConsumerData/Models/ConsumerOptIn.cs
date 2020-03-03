using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumer_opt_in")]
    public class ConsumerOptIn : Entity
    {
        [Column("consumer_opt_in_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("consumer_profile_id")]
        public Guid ConsumerProfileId { get; set; }
        [Column("key")]
        public string Key { get; set; }
        [Column("value")]
        public string Value { get; set; }
    }
}
