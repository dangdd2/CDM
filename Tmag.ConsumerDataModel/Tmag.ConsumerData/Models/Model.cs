using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("model")]
    public class Model : Entity
    {
        [Column("model_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid? Id { get; set; }

        [Column("model_name")]
        public string Name { get; set; }

        [Column("image_thumb")]
        public string ImageThumb { get; set; }
        [Column("image_small")]
        public string ImageSmall { get; set; }
        [Column("image_reg")]
        public string ImageReg { get; set; }
        [Column("image_large")]
        public string ImageLarge { get; set; }

        [Column("club_brand_id")]
        public Guid? BrandId { get; set; }
        [Column("third_party_id")]
        public string ThirdPartyId { get; set; }
        public DateTime? Deleted { get; set; }        
    }
}
