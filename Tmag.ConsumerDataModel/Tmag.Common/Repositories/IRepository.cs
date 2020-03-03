using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Tmag.Common.Models;

namespace Tmag.Common.Repositories
{
    public interface IRepository
    {
        DatabaseAction Delete<T>(Guid id) where T : class, IEntity;
        DatabaseAction Delete<T>(T entity) where T : class, IEntity;
        IQueryable<T> GetCollection<T>() where T : class, IEntity;
        void ReloadContext();
        DbContext GetDatabase();
        DatabaseAction MarkDeleted<T>(T entity, bool deleted = true) where T : class, IEntity;
        IQueryable<T> Query<T>(Expression<Func<T, bool>> expression = null) where T : class, IEntity;
        void Save();
        DatabaseAction Save<T>(T entity) where T : class, IEntity;
        DatabaseAction SaveQueue<T>(T entity) where T : class, IEntity;
    }
}