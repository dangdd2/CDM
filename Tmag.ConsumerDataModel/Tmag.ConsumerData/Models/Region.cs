using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("region")]
    public class Region : Entity
    {
        [Column("region_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Required]
        [Column("region_code")]
        public string Code { get; set; }
        [Column("region_desc")]
        public string Description { get; set; }
        public virtual List<ConsumerProfile> ConsumerProfiles { get; set; }
        public virtual List<ConsumerEmail> ConsumerEmails { get; set; }
    }
}
