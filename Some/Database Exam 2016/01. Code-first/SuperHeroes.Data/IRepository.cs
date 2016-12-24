using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SuperHeroes.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> All();

        IEnumerable<T> All(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);
    }
}
