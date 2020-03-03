using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tmag.Common.Models
{
    public abstract class Entity : IEntity
    {
        public abstract Guid? Id { get; set; }
        [Column("created_by")]
        [JsonProperty()]
        
        public string CreatedBy { get; set; }
        [Column("created")]
        [JsonProperty()]
        public DateTime Created { get; set; }
        [Column("modified")]
        [JsonProperty()]
        public DateTime Modified { get; set; }
        [Column("modified_by")]
        [JsonProperty()]
        public string ModifiedBy { get; set; }
        
    }
}
