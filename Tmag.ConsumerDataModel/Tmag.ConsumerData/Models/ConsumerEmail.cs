using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumer_emails")]
    public class ConsumerEmail : Entity
    {
        [Column("consumer_email_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("email")]
        [Required]
        public string Email { get; set; }
        [Column("consumer_id")]
        public Guid ConsumerProfileId { get; set; }
        [Column("source")]
        [Required]
        public string Source { get; set; }
        public virtual Consumer ConsumerMaster { get; set; }
    }
}
