using VetApp.Application.RepositoryInterfaces;
using VetApp.Domain.Entities;
using VetApp.Infrastructure.Database;

namespace VetApp.Infrastructure.Repositories
{
    public class OwnerRepository(VetAppDbContext context) : GenericRepository<Owner>(context), IOwnerRepository
    {
    }
}