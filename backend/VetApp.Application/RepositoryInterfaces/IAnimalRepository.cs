using VetApp.Domain.Entities;

namespace VetApp.Application.RepositoryInterfaces
{
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        Task<Animal> GetByOwnerIdAsync(long id);
    }
}