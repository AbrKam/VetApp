using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using VetApp.Domain.Commons.Enums;

namespace VetApp.Domain.Commons.Entities
{
    public class Veterinarian : BaseEntity
    {
        private Veterinarian(){}
        public Veterinarian(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = Guard.NotNullOrWhiteSpace(firstName, nameof(firstName));
            LastName = Guard.NotNullOrWhiteSpace(lastName, nameof(lastName));
            Email = Guard.NotNullOrWhiteSpace(email, nameof(email));
            PhoneNumber = Guard.NotNullOrWhiteSpace(phoneNumber, nameof(phoneNumber));
        }

        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public string Email {get; private set;}
        public string PhoneNumber {get; private set;}
        private List<Appointment> _appointments = new List<Appointment>();
        public IReadOnlyCollection<Appointment> Appointments => _appointments.AsReadOnly();

        public void SetFirstName(string firstName)
            => Guard.NotNullOrWhiteSpace(firstName, nameof(firstName));
        public void SetLastName(string lastName)
            => Guard.NotNullOrWhiteSpace(lastName, nameof(lastName));
        public void SetEmail(string email)
            => Guard.NotNullOrWhiteSpace(email, nameof(email));
        public void SetPhoneNumber(string phoneNumber)
            => Guard.NotNullOrWhiteSpace(phoneNumber, nameof(phoneNumber));
        public void AddAppointment(Appointment appointment)
        {
            ArgumentNullException.ThrowIfNull(appointment, nameof(appointment));

            if(_appointments.Any(x => x.Id == appointment.Id))
                throw new ArgumentException(
                    "This appointment is already assigned to this veterinarian!", nameof(appointment));

            _appointments.Add(appointment);
        }
    }
}