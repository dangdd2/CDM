using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumers")]
    public class Consumer : Entity, ISoftDelete
    {
        [Key]
        [Column("consumer_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("primary_email")]
        public string PrimaryEmail { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("first_name_kana")]
        public string FirstNameKana { get; set; }
        [Column("last_name_kana")]
        public string LastNameKana { get; set; }
        [Column("dob", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
        [Column("gender_id")]
        public Guid? GenderId { get; set; }
        public virtual List<ConsumerProfile> ConsumerProfiles { get; set; }
        public virtual GolferProfile GolferProfile { get; set; }
        public virtual List<ConsumerBagPanelCampaign> ConsumerBagPanelCampaigns { get; set; }
        public virtual Gender GenderLookUp { get; set; }
        public DateTime? Deleted
        {
            get;
            set;
        }
    }
}
