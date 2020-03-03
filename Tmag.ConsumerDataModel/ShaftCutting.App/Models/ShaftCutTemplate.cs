using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tmag.Common.Models;

namespace ShaftCutting.App.Models
{
    public class ShaftCutTemplate: Entity, ISoftDelete
    {
    public override Guid? Id { get; set; }
    public string Type { get; set; }
    public string Text { get; set; }
    public string Color { get; set; }
    public DateTime? Deleted { get; set; }
  }
}
