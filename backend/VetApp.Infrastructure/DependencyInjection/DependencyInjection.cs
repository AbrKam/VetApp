using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetApp.Application.Interfaces.RepositoryInterfaces;
using VetApp.Infrastructure.Database;
using VetApp.Infrastructure.Repositories;

namespace VetApp.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VetAppDbContext>(
                options => options.UseNpgsql(configuration.GetConnectionString("VetApp")));  

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<IVeterinarianRepository, VeterinarianRepository>();
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();

            return services;
        }
    }
}