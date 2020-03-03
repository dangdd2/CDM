using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("experience_location")]
    public class ExperienceLocation : Entity
    {
        [Column("experience_location_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("location_name")]
        public string Name { get; set; }
        public virtual List<ConsumerExperience> ConsumerExperiences { get; set; }
    }
}
