using VetApp.Application.Interfaces.RepositoryInterfaces;
using VetApp.Domain.Entities;
using VetApp.Infrastructure.Database;

namespace VetApp.Infrastructure.Repositories
{
    public class VeterinarianRepository(VetAppDbContext contex) : GenericRepository<Veterinarian>(contex), IVeterinarianRepository
    {
    }
}