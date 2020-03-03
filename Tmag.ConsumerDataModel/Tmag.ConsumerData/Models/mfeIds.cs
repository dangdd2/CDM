using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tmag.Common.Models;

namespace Tmag.ConsumerData.Models
{
    [Table("mfe-userIds")]
    public class MfeUserIds : IEntity
    {
        private Guid? _id;

        [Key]
        [Column("F1")]
        public  string Id { get; set; }

        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        Guid? IEntity.Id
        {
            get => _id;
            set => _id = value;
        }
    }
}
