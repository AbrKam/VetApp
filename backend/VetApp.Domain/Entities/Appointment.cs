using VetApp.Domain.Commons.Enums;
using VetApp.Domain.Entities;

namespace VetApp.Domain.Commons.Entities
{
    public class Appointment : BaseEntity
    {
        private Appointment(){}

        public Appointment(Animal animal, Veterinarian veterinarian, DateTime startAt, 
            DateTime endAt, AppointmentPurpose appointmentPurpose, AppointmentStatus appointmentStatus)
        {
            Guard.ValidateStartAndEnd(startAt, endAt);

            Animal = Guard.NotNull(animal, nameof(animal));
            Veterinarian = Guard.NotNull(veterinarian, nameof(veterinarian));
            
            StartAt = startAt;
            EndAt = endAt;
            AppointmentPurpose = appointmentPurpose;
            AppointmentStatus = appointmentStatus;
        }

        public Animal Animal {get; private set;}
        public Veterinarian Veterinarian {get; private set;}
        public DateTime StartAt {get; private set;}
        public DateTime EndAt {get; private set;}
        public AppointmentPurpose AppointmentPurpose {get; private set;}
        public AppointmentStatus AppointmentStatus {get; private set;}
        public string AppointmentSummary {get; private set;} = "";

        public void Reschedule(DateTime startAt, DateTime endAt)
        {
            Guard.ValidateStartAndEnd(startAt, endAt);
            StartAt = startAt;
            EndAt = endAt;
        }
        public void SetAppointmentPurpose(AppointmentPurpose appointmentPurpose)
            => AppointmentPurpose = appointmentPurpose;
        public void SetAppointmentSummary(string appointmentSummary)
            => AppointmentSummary = Guard.NotNull(appointmentSummary, nameof(appointmentSummary));
        public void SetAppointmentStatus(AppointmentStatus appointmentStatus)
            => AppointmentStatus = appointmentStatus;
    }
}