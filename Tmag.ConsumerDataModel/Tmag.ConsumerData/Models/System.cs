using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("systems")]
    public class System :Entity
    {
        [Column("system_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("identity_id")]
        public Guid? IdentityId { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("ip_start_range")]
        [DefaultValue("0.0.0.0")]
        public string IpStartRange { get; set; }
        [Column("ip_end_range")]
        [DefaultValue("255.255.255.255")]
        public string IpEndRange { get; set; }
        public virtual List<SystemToConsumerProfile> SystemToConsumerProfiles { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
