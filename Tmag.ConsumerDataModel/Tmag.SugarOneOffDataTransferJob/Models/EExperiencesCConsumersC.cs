using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tmag.SugarOneOffDataTransferJob.Models
{
    public partial class EExperiencesCConsumersC
    {
        public string Id { get; set; }
        public DateTime? DateModified { get; set; }
        public short? Deleted { get; set; }
        public string EExperiencesCConsumerscConsumersIda { get; set; }
        public string EExperiencesCConsumerseExperiencesIdb { get; set; }

        [ForeignKey("EExperiencesCConsumerseExperiencesIdb")]
        public virtual EExperiences EExperience { get; set; }

        [ForeignKey("EExperiencesCConsumerscConsumersIda")]
        public virtual CConsumers CConsumer { get; set; }
    }
}
