using VetApp.Domain.Entities;

namespace VetApp.Application.RepositoryInterfaces
{
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        Task<List<Animal>> GetByOwnerIdAsync(long id);
    }
}