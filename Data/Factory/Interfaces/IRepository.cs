namespace Data.Factory.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>>GetAll();
        Task<T> GetById (long id);
        Task<bool>Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}