using System.Runtime.CompilerServices;
using VetApp.Domain.Commons;
using VetApp.Domain.Commons.Entities;
using VetApp.Domain.Commons.Enums;

namespace VetApp.Domain.Entities
{
    public class Animal: BaseEntity
    {
        public Animal(){}
        public Animal(Owner owner, string name, DateOnly birthDate, AnimalSpecies species, string breed, AnimalGender gender)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            Name = name;
            BirthDate = birthDate;
            Species = species;
            Breed = breed;
            Gender = gender;
        }

        public string Name {get; private set;}
        public DateOnly BirthDate {get; private set;}
        public AnimalSpecies Species {get; private set;}
        public string Breed {get; private set;}
        public AnimalGender Gender {get; private set;}
        public List<Appointment> LastAppointments {get; private set;} = new List<Appointment>();
        public Owner Owner {get; private set;}

        public void SetName(string name) 
            => Name = name;
        public void SetBirthDate(DateOnly date)
            => BirthDate = date;
        public void SetBreed(string breed)
            => Breed = breed;
        public void SetGender(AnimalGender gender)
            => Gender = gender;
    }
}
