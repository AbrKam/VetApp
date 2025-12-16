namespace VetApp.Domain.Commons.Entities
{
    public class Veterinarian : BaseEntity
    {
        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public string Email {get; private set;}
        public string TelephoneNumber {get; private set;}
        public List<Appointment> Appointments {get; private set;}
    }
}