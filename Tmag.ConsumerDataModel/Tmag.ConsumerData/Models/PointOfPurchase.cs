using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("point_of_purchase")]
    public class PointOfPurchase : Entity
    {
        [Column("point_of_purchase_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("point_of_purchase")]
        public string Type { get; set; }
        [Column("description")]
        public string Description { get; set; }
        public virtual List<ConsumerBagPanelCampaign> ConsumerBagPanelCampaigns { get; set; }
    }
}
