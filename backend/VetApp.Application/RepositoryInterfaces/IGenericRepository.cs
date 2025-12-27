namespace VetApp.Application.RepositoryInterfaces
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(long id);
        Task<List<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task UpdateAsync(T entity);
    }    
}