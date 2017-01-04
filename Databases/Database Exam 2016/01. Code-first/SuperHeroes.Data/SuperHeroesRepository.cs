using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SuperHeroes.Data
{
    public class SuperHeroesRepository<T> : IRepository<T> where T : class
    {
        private DbContext context;
        private DbSet<T> set;

        public SuperHeroesRepository(DbContext context)
        {
            this.context = context;
            this.set = this.context.Set<T>();
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
