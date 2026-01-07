using VetApp.Application.RepositoryInterfaces;
using VetApp.Domain.Entities;
using VetApp.Infrastructure.Database;

namespace VetApp.Infrastructure.Repositories
{
    public class VeterinarianRepository(VetAppDbContext contex) : GenericRepository<Veterinarian>(contex), IVeterinarianRepository
    {
    }
}