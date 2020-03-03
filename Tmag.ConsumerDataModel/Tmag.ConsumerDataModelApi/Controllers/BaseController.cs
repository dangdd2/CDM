using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tmag.Common.Models;
using Tmag.Common.Repositories;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Tmag.ConsumerDataModelApi.Controllers
{
    public class BaseController<T> : Controller where T : class, IEntity
    {
        protected readonly ILogger _logger;
        protected readonly IRepository _repository;
        private readonly string _objectName;

        public BaseController(IRepository repository, ILoggerFactory loggerFactory)
        {
            _repository = repository;
            _objectName = typeof(T).Name;
            _logger = loggerFactory.CreateLogger(_objectName);
        }

        public BaseController(IRepository repository)
        {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public  IQueryable<T> Get([FromQuery]int take, [FromQuery]int skip)
        {
            _logger.LogInformation("{0} - Action <Get> take[{1}] - skip[{2}]", _objectName, take, skip);
            return _repository.Query<T>().Skip(skip).Take(take);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public T GetById(Guid id)
        {
            _logger.LogInformation("{0} - Action <GetById> take[{1}]", _objectName, id);
            return _repository.Query<T>().FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public T Post([FromBody]T value)
        {
            _logger.LogInformation("{0} - Action <Post>", _objectName);
            _logger.LogDebug(JsonConvert.SerializeObject(value));
            _repository.Save(value);
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public T Put(int id, [FromBody]T value)
        {
            _logger.LogInformation("{0} - Action <Put>", _objectName);
            _logger.LogDebug(JsonConvert.SerializeObject(value));
            _repository.Save(value);
            return value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            _logger.LogInformation("{0} - Action <Delete> id[{1}]", _objectName, id);
            var item = _repository.Query<T>().FirstOrDefault(x => x.Id == id);

            if (item == null) return false;

            var softDeleteItem = item as ISoftDelete;

            if(softDeleteItem != null)
            {
                ((ISoftDelete)item).Deleted = DateTime.UtcNow;
                _repository.Save(item);
            }
            else
            {                
                throw new Exception();
            }
            return true;
        }
    }
}
