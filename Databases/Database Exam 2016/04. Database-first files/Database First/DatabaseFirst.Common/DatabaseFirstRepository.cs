using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DatabaseFirst.Common
{
    public class DatabaseFirstRepository<T> : IRepository<T> where T : class
    {
        private DbContext context;
        private DbSet<T> set;

        public DatabaseFirstRepository(DbContext context)
        {
            this.context = context;
            this.set = this.context.Set<T>();
        }

        public T GetById(object id)
        {
            return this.set.Find(id);
        }

        public void Add(T entity)
        {
            var entry = this.context.Entry(entity);
            entry.State = EntityState.Added;
        }

        public IEnumerable<T> All()
        {
            return this.set.ToList();
        }

        public IEnumerable<T> All(Expression<Func<T, bool>> filter)
        {
            return this.set.Where(filter).ToList();
        }

        public void Delete(T entity)
        {
            var entry = this.context.Entry(entity);
            entry.State = EntityState.Deleted;
        }
    }
}
