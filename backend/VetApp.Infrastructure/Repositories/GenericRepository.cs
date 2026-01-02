using Microsoft.EntityFrameworkCore;
using VetApp.Application.RepositoryInterfaces;
using VetApp.Infrastructure.Database;

namespace VetApp.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly VetAppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(VetAppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();    
        }

        public async Task<T> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id) ?? 
                throw new InvalidOperationException($"Could not find {typeof(T)} with given id = {id}!");
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task AddAsync(T entity) 
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveAsync(T entity) 
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(T entity) 
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}