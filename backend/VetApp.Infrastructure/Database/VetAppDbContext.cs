using System.Dynamic;

namespace VetApp.Infrastructure
{
    public class VetAppDbContext : DbContext
    {
        public VetAppDbContext(DbContextOptions<VetAppDbContext> options) : base(options)
        {
        }

        public DbSet<Animal> Animals => Set<Animal>();
        public DbSet<Owner> Owners => Set<Owner>();
        public DbSet<Veterinarian> Veterinarians => Set<Veterinarian>();
        public DbSet<Appointment> Appointments => Set<Appointment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VetAppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}