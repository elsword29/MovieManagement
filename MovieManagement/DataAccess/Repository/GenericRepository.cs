using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.IRepository;

namespace MovieManagement.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> dbSet;
        public GenericRepository(AppDbContext appDbContext)
        {
            dbSet = appDbContext.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            dbSet.Update(entity);
        }

        public List<T> GetAll()
        {
            var list = dbSet.ToList();
            return list;
        }

        public T GetById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity is null)
            {
                throw new Exception($"Can not found by id {id}");
            }
            return entity;
        }
    }
}
