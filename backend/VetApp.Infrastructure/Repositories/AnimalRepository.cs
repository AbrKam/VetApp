using VetApp.Infrastructure.Database;
using VetApp.Domain.Entities;
using VetApp.Application.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace VetApp.Infrastructure.Repositories
{
    public class AnimalRepository : GenericRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(VetAppDbContext context) : base(context) {}
        public Task<List<Animal>> GetByOwnerIdAsync(long id)
            => _dbSet
                .Where(x => x.Owner.Id == id)
                .ToListAsync();
    }
}