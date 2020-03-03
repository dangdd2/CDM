using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tmag.Common;
using Microsoft.Extensions.Options;
using ShaftCutting.App.Models;

namespace ShaftCutting.App.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    private readonly Context DbContext;

    public ValuesController(IOptions<ConnectionStrings> settings)
    {
      var connectionString = settings.Value.MainDb;
      DbContext = new Context(connectionString);

    }
    // GET api/values
    [HttpGet]
    public List<ShaftCutTemplate> Get()
    {
      return DbContext.Set<ShaftCutTemplate>().Where(x => !x.Deleted.HasValue).ToList();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public List<ShaftCutTemplate> Post([FromBody]List<ShaftCutTemplate> values)
    {
      foreach (var item in values)
      {
        if (item.Id.HasValue)
        {
          DbContext.Set<ShaftCutTemplate>().Add(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        } else {
          item.Id = Guid.NewGuid();
          DbContext.Set<ShaftCutTemplate>().Add(item).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        }
      }
      DbContext.SaveChanges();

      return values;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
