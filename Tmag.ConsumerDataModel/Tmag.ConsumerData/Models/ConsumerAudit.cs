using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumers_audit")]
    public class ConsumerAudit : Entity
    {
        [Column("audit_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  Guid? AuditId { get; set; }
        [Column("consumer_id")]
        public override Guid? Id { get; set; }
        [Column("primary_email")]
        public string PrimaryEmail { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("dob")]
        public DateTime? Dob { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
