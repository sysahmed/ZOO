using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ZOO.Core.Entities;

namespace ZOO.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
       
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
