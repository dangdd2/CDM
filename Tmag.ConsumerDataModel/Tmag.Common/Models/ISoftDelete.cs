using System;

namespace Tmag.Common.Models
{
    public interface ISoftDelete
    {
        DateTime? Deleted { get; set; }
    }
}
