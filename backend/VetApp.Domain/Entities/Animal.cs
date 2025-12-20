using System.Runtime.CompilerServices;
using VetApp.Domain.Commons;
using VetApp.Domain.Commons.Entities;
using VetApp.Domain.Commons.Enums;

namespace VetApp.Domain.Entities
{
    public class Animal: BaseEntity
    {
        private Animal(){}
        public Animal(Owner owner, string name, DateOnly birthDate, AnimalSpecies species, string breed, AnimalGender gender)
        {
            Owner = Guard.NotNull(owner, nameof(owner));
            Name = Guard.NotNullOrWhiteSpace(name, nameof(name));
            BirthDate = birthDate;
            Species = species;
            Breed = Guard.NotNullOrWhiteSpace(breed, nameof(breed));
            Gender = gender;
        }

        public string Name {get; private set;}
        public DateOnly BirthDate {get; private set;}
        public AnimalSpecies Species {get; private set;}
        public string Breed {get; private set;}
        public AnimalGender Gender {get; private set;}
        public Owner Owner {get; private set;}
        private readonly List<Appointment> _appointments = new List<Appointment>();
        public IReadOnlyCollection<Appointment> Appointments => _appointments.AsReadOnly();

        public void SetName(string name) 
            => Name = Guard.NotNullOrWhiteSpace(name, nameof(name));
        public void SetBirthDate(DateOnly date)
        {
            if (date > DateOnly.FromDateTime(DateTime.UtcNow))
            {
                throw new ArgumentException("Birth date cannot be in the future!");
            }
            BirthDate = date;
        }
        public void SetBreed(string breed)
            => Breed = Guard.NotNullOrWhiteSpace(breed, nameof(breed));
        public void SetGender(AnimalGender gender)
            => Gender = gender;
        public void AddAppointment(Appointment appointment)
        {
            ArgumentNullException.ThrowIfNull(appointment, nameof(appointment));

            if (_appointments.Any(x => x.Id == appointment.Id))
                throw new ArgumentException("This appointment is already assigned to this animal!", nameof(appointment));

            _appointments.Add(appointment);
        }
    }
}
