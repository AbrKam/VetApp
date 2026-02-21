using Microsoft.Extensions.DependencyInjection;
using VetApp.Application.Interfaces.ServiceInterfaces;
using VetApp.Application.Services;

namespace VetApp.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IOwnerService, OwnerService>();

            return services;
        }
    }
}