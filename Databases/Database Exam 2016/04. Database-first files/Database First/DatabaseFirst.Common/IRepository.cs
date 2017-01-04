using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DatabaseFirst.Common
{
    public interface IRepository<T>
    {
        T GetById(object id);

        IEnumerable<T> All();

        IEnumerable<T> All(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);
    }
}
