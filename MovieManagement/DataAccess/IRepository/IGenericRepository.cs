namespace MovieManagement.DataAccess.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Edit(T entity);
        public void Delete(T entity);
        public void Add(T entity);
    }
}
