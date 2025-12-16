using VetApp.Domain.Commons;
using VetApp.Domain.Commons.Entities;
using VetApp.Domain.Commons.Enums;

namespace VetApp.Domain.Entities
{
    public class Animal: BaseEntity
    {
        public string Name {get; private set;}
        public DateOnly BirthDate {get; private set;}
        public AnimalSpecies Species {get; private set;}
        public AnimalGender Gender {get; private set;}
        public List<Appointment> LastAppointments {get; private set;} = new List<Appointment>();
        public Owner Owner {get; private set;}
    }
}
