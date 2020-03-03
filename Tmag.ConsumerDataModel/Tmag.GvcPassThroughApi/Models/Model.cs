using System;

namespace Tmag.GvcPassThroughApi.Models
{
    public class Model
    {
        public  Guid? Id { get; set; }
        public string Name { get; set; }
        public string ImageThumb { get; set; }
        public string ImageSmall { get; set; }
        public string ImageReg { get; set; }
        public string ImageLarge { get; set; }
        public Guid? BrandId { get; set; }
        public string ThirdPartyId { get; set; }       
    }
}
