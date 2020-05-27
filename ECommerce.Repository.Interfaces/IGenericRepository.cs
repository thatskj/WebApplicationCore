namespace ECommerce.Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Delete(object id);
        System.Collections.Generic.IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}
