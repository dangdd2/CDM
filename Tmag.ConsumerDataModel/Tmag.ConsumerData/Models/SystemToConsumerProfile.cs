using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("system_to_consumer_profile")]
    public class SystemToConsumerProfile : Entity
    {
        [Column("system_to_consumer_profile_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("consumer_profile_id")]
        public Guid ConsumerProfileId { get; set; }
        [Column("system_id")]
        public Guid SystemId { get; set; }
        public virtual ConsumerProfile ConsumerProfile { get; set; }
        public virtual System System { get; set; }
    }
}
