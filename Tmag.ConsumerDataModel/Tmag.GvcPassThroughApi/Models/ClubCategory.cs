using System;
using System.Collections.Generic;

namespace Tmag.GvcPassThroughApi.Models
{
    public class ClubCategory
    {
        public Guid? Id { get; set; }
        
        public string Name { get; set; }
        public virtual List<Brand> brands { get; set; }
    }
}
