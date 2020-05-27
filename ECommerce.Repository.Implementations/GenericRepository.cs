using ECommerce.Domain.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Repository.Implementations
{
    class GenericRepository<TEntity> : Interfaces.IGenericRepository<TEntity> where TEntity : class
    {
        readonly DbSet<TEntity> dbSetTable;
        readonly ECommerceContext context;

        //Should use this contrustors in rare case as it initializes the entire context
        public GenericRepository()
        {
            this.context = new ECommerceContext();
            dbSetTable = context.Set<TEntity>();
        }

        public GenericRepository(ECommerceContext eCommerceContext)
        {
            this.context = eCommerceContext;
            dbSetTable = eCommerceContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSetTable.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbSetTable.Find(id);
        }

        public void Insert(TEntity entity)
        {
            dbSetTable.Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbSetTable.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            TEntity existing = dbSetTable.Find(id);
            dbSetTable.Remove(existing);
        }
        
       
    }
}
