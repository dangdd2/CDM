using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumer_profile")]
    public class ConsumerProfile : Entity
    {
        [Column("consumer_profile_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("region_id")]
        public Guid RegionId { get; set; }
        [Column("phone_home")]
        public string PhoneHome { get; set; }
        [Column("phone_cell")]
        public string PhoneCell { get; set; }
        [Column("notes")]
        public string Notes { get; set; }
        [Column("member_rank")]
        public string MemberRank { get; set; }
        [Column("address_id")]
        public Guid? AddressId { get; set; }
        [Column("consumer_id")]
        public Guid ConsumerId { get; set; }
        [ForeignKey("ConsumerId")]
        public virtual Consumer Consumer{ get; set; }
        public virtual Address Address { get; set; }
        public virtual Region Region { get; set; }
        public virtual List<ConsumerExperience> ConsumerExperiences { get; set; }
        public virtual List<SystemToConsumerProfile> SystemToConsumerProfiles { get; set; }
        public virtual List<ConsumerOptIn> ConsumerOptIns { get; set; }        
    }
}
