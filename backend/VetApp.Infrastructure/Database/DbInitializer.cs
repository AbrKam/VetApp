using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetApp.Domain.Entities;

namespace VetApp.Infrastructure.Database
{
    public static class DbInitializer
    {
        public static async Task Initialize(VetAppDbContext context)
        {
            await context.Database.MigrateAsync();
            if (await context.Owners.AnyAsync()) return;

            var owner = new Owner(
                "Musashi", 
                "Miyamoto", 
                "takezo345@example.pl", 
                "543564654");
            var animal = new Animal(
                owner, 
                "Louis", 
                new DateOnly(2020, 2, 27), 
                Domain.Commons.Enums.AnimalSpecies.Dog, 
                "Crossbreed", 
                Domain.Commons.Enums.AnimalGender.Male);
            var veterinarian = new Veterinarian(
                "Sasaki", 
                "Kojiro", 
                "s.kojiro@vetclinic.pl", 
                "675312453");

            var startAt = new DateOnly(2026, 2, 22).ToDateTime(new TimeOnly(14, 45));
            var endAt   = new DateOnly(2026, 2, 22).ToDateTime(new TimeOnly(15, 00));
            var appointment = new Appointment(
                animal, 
                veterinarian, 
                startAt,
                endAt,
                Domain.Commons.Enums.AppointmentPurpose.HealthCheck,
                Domain.Commons.Enums.AppointmentStatus.Planned);

            context.AddRange(owner, animal, veterinarian, appointment);

            await context.SaveChangesAsync();
        }
    }
}