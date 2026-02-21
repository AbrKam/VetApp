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

            await context.Owners.AddAsync(owner);
            await context.SaveChangesAsync();

            var animal = new Animal(
                owner.Id, 
                "Louis", 
                new DateOnly(2020, 2, 27), 
                Domain.Commons.Enums.AnimalSpecies.Dog, 
                "Crossbreed", 
                Domain.Commons.Enums.AnimalGender.Male);
            
            await context.Animals.AddAsync(animal);
            await context.SaveChangesAsync();
            
            var veterinarian = new Veterinarian(
                "Sasaki", 
                "Kojiro", 
                "s.kojiro@vetclinic.pl", 
                "675312453");

            await context.Veterinarians.AddAsync(veterinarian);
            await context.SaveChangesAsync();

            var startAt = DateTime.SpecifyKind(new DateOnly(2026, 2, 22).ToDateTime(new TimeOnly(14, 45)), DateTimeKind.Utc);
            var endAt   = DateTime.SpecifyKind(new DateOnly(2026, 2, 22).ToDateTime(new TimeOnly(15, 00)), DateTimeKind.Utc);
            var appointment = new Appointment(
                animal.Id, 
                veterinarian.Id,
                startAt,
                endAt,
                Domain.Commons.Enums.AppointmentPurpose.HealthCheck,
                Domain.Commons.Enums.AppointmentStatus.Planned);

            await context.Appointments.AddAsync(appointment);
            await context.SaveChangesAsync();
        }
    }
}