using System;
using System.Collections.Generic;

namespace Tmag.GvcPassThroughApi.Models
{
    public class Brand
    {
        public  Guid? Id { get; set; }
        public string Name { get; set; }
        public Guid? ClubCategoryId { get; set; } 
        public virtual List<Model> Models { get; set; }
    }
}
