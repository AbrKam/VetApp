using VetApp.Domain.Entities;

namespace VetApp.Domain.Commons.Entities
{
    public class Appointment : BaseEntity
    {
        public Animal Animal {get; private set;}
        public Veterinarian Veterinarian {get; private set;}
        public DateTime AppointmentDate {get; private set;}
        public AppointmentPurpose AppointmentPurpose {get; private set;}
        public string AppointmentSummary {get; private set;}
    }
}