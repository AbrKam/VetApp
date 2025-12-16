using VetApp.Domain.Entities;

namespace VetApp.Domain.Commons.Entities
{
    public class Owner : BaseEntity
    {
        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public string Email {get; private set;}
        public string TelephoneNumber {get; private set;}
        public List<Animal> Animals {get; private set;} = new List<Animal>();

    }
}