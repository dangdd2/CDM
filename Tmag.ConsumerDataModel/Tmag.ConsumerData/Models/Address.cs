using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("addresses")]
    public class Address :Entity
    {
        [Column("address_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("address_line_1")]
        public string AddressLine1 { get; set; }
        [Column("address_line_2")]
        public string AddressLine2 { get; set; }
        [Column("address_line_3")]
        public string AddressLine3 { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("zipcode")]
        [Required]
        public string ZipCode { get; set; }
        [Column("country")]
        [Required]
        public string Country { get; set; }
        [Column("system_id")]
        public Guid SystemId { get; set; }
        public virtual ConsumerProfile ConsumerProfile { get; set; }
        public virtual ConsumerBagPanelCampaign ConsumerBagPanelCampaign { get; set; }
        public virtual RetailStore RetailStore { get; set; }
        public virtual System System { get; set; }
        public virtual ConsumerExperience ConsumerExperiences { get; set; }
    }
}
