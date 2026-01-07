using VetApp.Application.RepositoryInterfaces;
using VetApp.Domain.Entities;
using VetApp.Infrastructure.Database;

namespace VetApp.Infrastructure.Repositories
{
    public class AppointmentRepository(VetAppDbContext context) : GenericRepository<Appointment>(context), IAppointmentRepository
    {
        
    }
}