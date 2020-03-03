using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("retail_store")]
    public class RetailStore : Entity
    {
        [Column("retail_store_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
      
        [Column("shipto")]
        public string ShipToId { get; set; }
        [Required]
        [Column("display_name")]
        public string BillingName { get; set; }
        [Column("billing_address")]
        public Guid BillingAddressId { get; set; }
        [Column("phone_office")]
        public string PhoneOffice { get; set; }
        [Column("phone_fax")]
        public string PhoneFax { get; set; }
        [Column("store_hours")]
        public string StoreHours { get; set; }
        [Column("website")]
        public string Website { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("leadrank")]
        public string LeadRank { get; set; }
        [Column("is_tmpl_location")]
        public bool IsTmplLocation { get; set; }
        [Column("is_fitting_location")]
        public bool IsFittingLocation { get; set; }
        [Column("is_tm_studio")]
        public bool IsTmStudio { get; set; }
        [Column("is_premium_location")]
        public bool IsPremiumLocation { get; set; }
        [Column("is_certified_location")]
        public bool IsCertifiedLocation { get; set; }
        public virtual Consumer ConsumerMaster { get; set; }
        [ForeignKey("BillingAddressId")]
        public virtual Address BillingAddress { get; set; }
        public virtual Region Region { get; set; }
    }
}
