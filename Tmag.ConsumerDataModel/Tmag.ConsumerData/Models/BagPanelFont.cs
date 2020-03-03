using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("bag_panel_fonts")]
    public class BagPanelFont : Entity
    {
        [Column("bag_panel_font_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("font_type")]
        public string Type { get; set; }
        public virtual List<ConsumerBagPanelCampaign> ConsumerBagPanelCampaigns { get; set; }
    }
}
