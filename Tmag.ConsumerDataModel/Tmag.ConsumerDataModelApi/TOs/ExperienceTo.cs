using System;
using Tmag.ConsumerData.Models;

namespace Tmag.ConsumerDataModelApi.TOs
{
    public class ExperienceTo
    {
        public Guid? ConsumerId { get; set; }
        public string Email { get; set; }
        public Guid? RegionId { get; set; }
        public ConsumerExperience ConsumerExperience { get; set; }      
    }
}
