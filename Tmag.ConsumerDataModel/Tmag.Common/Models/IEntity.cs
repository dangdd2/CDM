using System;

namespace Tmag.Common.Models
{
    public interface IEntity
    {
        Guid? Id { get; set; }
        DateTime Created { get; set; }
        string CreatedBy { get; set; }
        DateTime Modified { get; set; }
        string ModifiedBy { get; set; }
    }
}
