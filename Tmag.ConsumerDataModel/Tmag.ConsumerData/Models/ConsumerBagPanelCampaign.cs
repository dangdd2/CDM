using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("consumer_bag_panel_campaigns")]
    public class ConsumerBagPanelCampaign : Entity
    {
        [Column("consumer_bag_panel_campaign_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }
        [Column("consumer_profile_id")]
        public Guid ConsumerProfileId { get; set; }
        [Column("item_number")]
        public string ItemNumber { get; set; }
        [Column("bag_model_id")]
        public Guid BagModelId { get; set; }
        [Column("panel_font_id")]
        public Guid BagPanelFontId { get; set; }
        [Column("text_line_1")]
        public string TextLine1 { get; set; }
        [Column("text_line_2")]
        public string TextLine2 { get; set; }
        [Column("text_line_3")]
        public string TextLine3 { get; set; }
        [Column("point_of_purchase")]
        public Guid PointOfPurchaseId { get; set; }
        [Column("bag_usage")]
        public string BagUsage { get; set; }
        [Column("best_feature")]
        public string BestFeature { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("bag_color")]
        public string BagColor { get; set; }
        [Column("bag_top_quality")]
        public string BagTopQuality { get; set; }
        [Column("opt_in_brand")]
        public string OptInBrand { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("address_id")]
        public Guid AddressId { get; set; }
        public virtual ConsumerProfile ConsumerProfile { get; set; }
        public virtual Address Address { get; set; }
        public virtual PointOfPurchase PointOfPurchase { get; set; }
        public virtual BagModel BagModel { get; set; }
        public virtual BagPanelFont BagPanelFont { get; set; }
    }
}
