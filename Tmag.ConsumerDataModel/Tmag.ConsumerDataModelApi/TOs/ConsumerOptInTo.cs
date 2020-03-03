using System;

namespace Tmag.ConsumerDataModelApi.TOs
{
    public class ConsumerOptInTo
    {
        public Guid? ConsumerOptInId { get; set; }
        public Guid? ConsumerId { get; set; }
        public Guid? RegionId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
