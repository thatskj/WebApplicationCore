using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Implementations
{
    class UnitOfWork : Interfaces.IUnitOfWork
    {
        public DbContext Context { get; }

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
