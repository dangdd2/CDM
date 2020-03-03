using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("whats_in_the_bag")]
    public class WhatsInTheBag : Entity, ISoftDelete
    {
        [Column("whats_in_the_bag_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("golfer_profile_id")]
        public Guid? GolferProfileId { get; set; }

        [Column("favorite")]
        public bool Favorite { get; set; }
        [Column("deleted")]
        public DateTime? Deleted { get; set; }
        [Column("category_id")]
        public Guid? ClubCategoryId { get; set; }
        [Column("brand_id")]
        public Guid? BrandId { get; set; }
        [Column("model_id")]
        public Guid? ModelId { get; set; }
        [Column("plan_to_purchase")]
        public bool PlanToPurchase { get; set; }
        [Column("sku")]
        public string Sku { get; set; }
        [Column("loft")]
        public Guid? ClubLoftId { get; set; }
        [Column("flex")]
        public Guid? ClubShaftFlexId { get; set; }
        [Column("shaft_length_id")]
        public Guid? ClubShaftLengthId { get; set; }
        [Column("face_lie_adjustment")]
        public Guid? FaceLieAdjustmentId { get; set; }
        [Column("face_loft_adjustment")]
        public Guid? FaceLoftAdjustmentId { get; set; }
        [Column("club_category_type_id")]
        public Guid? ClubCategoryTypeId { get; set; }
        public virtual GolferProfile GolferProfile { get; set; }
        public virtual ClubShaftLength ClubShaftLength { get; set; }

        [ForeignKey("ClubShaftFlexId")]
        public virtual ClubShaftFlex ClubShaftFlex { get; set; }
        [ForeignKey("ClubCategoryTypeId")]
        public virtual ClubCategoryType ClubCategoryType { get; set; }
        [ForeignKey("FaceLoftAdjustmentId")]
        public virtual ClubLoftAdjustment FaceLoftAdjustment { get; set; }
        [ForeignKey("ClubLoftId")]
        public virtual ClubLoft ClubLoft { get; set; }

        [ForeignKey("FaceLieAdjustmentId")]
        public virtual ClubLie FaceLieAdjustment { get; set; }

        [ForeignKey("ClubCategoryId")]
        public virtual ClubCategory ClubCategory { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        [ForeignKey("ModelId")]
        public virtual Model Model { get; set; }
    }
}
