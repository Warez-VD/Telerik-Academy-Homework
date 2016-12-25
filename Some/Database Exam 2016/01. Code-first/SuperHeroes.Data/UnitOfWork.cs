using System.Data.Entity;

namespace SuperHeroes.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }
    }
}
