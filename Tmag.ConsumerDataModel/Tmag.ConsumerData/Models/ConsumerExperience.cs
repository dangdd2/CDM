using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumer_experiences")]
    public class ConsumerExperience : Entity
    {
        [Column("consumer_experience_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        public string Name { get; set; }
        [Column("event_name")]
        public string EventName { get; set; }
        [Column("experience_date")]
        public DateTime ExperienceDate { get; set; }
        [Column("location")]
        public Guid? RetailStoreId { get; set; }
        [Column("consumer_profile_id")]
        public Guid ConsumerProfileId { get; set; }
        [Column("address_id")]
        public Guid? AddressId { get; set; }
        public virtual ConsumerProfile ConsumerProfile { get; set; }
        public virtual RetailStore RetailStore { get; set; }
        public virtual Address Address { get; set; }
    }
}
