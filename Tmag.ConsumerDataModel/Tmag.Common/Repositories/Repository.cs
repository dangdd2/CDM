using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tmag.Common.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace Tmag.Common.Repositories
{
    public class Repository : IRepository
    {
        protected string ConnectionString;
        protected DbContext DbContext { get; set; }
        protected string UserId { get; set; }
        private readonly ILogger _logger;

        public Repository()
        {

        }

        public Repository(IOptions<ConnectionStrings> settings, ILoggerFactory loggerFactory)
        {
            ConnectionString = settings.Value.MainDb;
            DbContext = new Context(ConnectionString);
            _logger = loggerFactory.CreateLogger("Repository");
        }

        public virtual void ReloadContext()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
                DbContext = new Context(ConnectionString);
            }
        }

        private const int DatabaseCommandTimeout = 1000;
        public virtual DbContext GetDatabase()
        {            
            if (DbContext == null)
            {
                DbContext = new Context(ConnectionString);
            }
            DbContext.Database.SetCommandTimeout(DatabaseCommandTimeout);
            return DbContext;
        }

        public IQueryable<T> GetCollection<T>() where T : class, IEntity
        {
            return GetDatabase().Set<T>();
        }

        public IQueryable<T> Query<T>(Expression<Func<T, bool>> expression = null) where T : class, IEntity
        {
            return expression == null ? GetCollection<T>() : GetCollection<T>().Where(expression);
        }

        public DatabaseAction SaveQueue<T>(T entity) where T : class, IEntity
        {
            DatabaseAction databaseAction = DatabaseAction.Failed;
            try
            {
                var e = entity as Entity;
                if (!e.Id.HasValue)
                {
                    UpdateChildModels(entity, 0);
                    GetDatabase().Set<T>().Add(entity);
                    databaseAction = DatabaseAction.Inserted;
                }
                else
                {
                    UpdateChildModels(entity, 0);
                    GetDatabase().Entry(entity).State = EntityState.Modified;
                    databaseAction = DatabaseAction.Updated;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return databaseAction;
        }

        public void Save()
        {
            GetDatabase().SaveChanges();
        }

        public DatabaseAction Save<T>(T entity) where T : class, IEntity
        {
            DatabaseAction databaseAction = SaveQueue(entity);
            Save();

            return databaseAction;
        }


        public DatabaseAction MarkDeleted<T>(T entity, bool deleted = true) where T : class, IEntity
        {
            var result = GetCollection<T>().FirstOrDefault(x => x.Id == entity.Id);

            if (result == null) return DatabaseAction.Failed;

            result.Modified = DateTime.UtcNow;

            GetDatabase().SaveChanges();

            return DatabaseAction.Deleted;
        }

        public DatabaseAction Delete<T>(T entity) where T : class, IEntity
        {

            if (entity.Id.HasValue)
                return Delete<T>(entity.Id.Value);
            throw new ArgumentNullException();
        }

        public DatabaseAction Delete<T>(Guid id) where T : class, IEntity
        {
            // TODO: methods calling this method directly are not "auditable"
            var obj = GetCollection<T>().SingleOrDefault(x => x.Id == id);

            if (obj == null) return DatabaseAction.Failed;

            GetDatabase().Remove(obj);
            GetDatabase().SaveChanges();

            return DatabaseAction.Deleted;
        }

        protected static string GetCollectionName<T>() where T : class, IEntity
        {
            var collectionName = typeof(T).Name;
            if (string.IsNullOrEmpty(collectionName))
                throw new ArgumentException("Collection name cannot be empty for this entity");

            return collectionName;
        }

        protected void UpdateChildModels(IEntity model, int branchCount, IEntity parent = null)
        {
            if (model.Id.HasValue)
            {
                model.ModifiedBy = UserId;
                model.Modified = DateTime.UtcNow;
            }
            else
            {
                // model.Id = Guid.NewGuid();
                model.CreatedBy = UserId;
                model.Created = DateTime.UtcNow;
                model.ModifiedBy = UserId;
                model.Modified = DateTime.UtcNow;
            }

            branchCount++;
            //if (branchCount > 5) return;

            Type modelType = model.GetType();
            foreach (PropertyInfo property in new List<PropertyInfo>(modelType.GetProperties()))
            {
                var valueProp = property.GetValue(model, null);

                if (valueProp == null) continue;

                if (parent != null && valueProp.GetType() == parent.GetType()) continue;

                var listProp = valueProp as IEnumerable<IEntity>;

                if (listProp == null)
                {
                    var propModel = valueProp as IEntity;
                    if (propModel != null)
                    {
                        
                        if (propModel.Id.HasValue)
                        {
                            propModel.Modified = DateTime.UtcNow;
                            propModel.ModifiedBy = UserId;

                        }
                        else
                        {
                          
                            propModel.Created = DateTime.UtcNow;
                            propModel.CreatedBy = UserId;
                            propModel.Modified = DateTime.UtcNow;
                            propModel.ModifiedBy = UserId;
                            
                        }
                       
                    }
                    continue;
                }
                var list = listProp.ToList();
                foreach (var prop in list)
                {
                    if (prop.Equals(parent)) continue;
                    
                    if (prop.Id.HasValue)
                    {
                        prop.Modified = DateTime.UtcNow;
                        prop.ModifiedBy = UserId;
                    }
                    else
                    {
                        prop.Created = DateTime.UtcNow;
                        prop.CreatedBy = UserId;
                        prop.Modified = DateTime.UtcNow;
                        prop.ModifiedBy = UserId;
                    }
                    UpdateChildModels(prop, branchCount, model);
                }
            }
        }
    }
}
