using VetApp.Domain.Commons;
using VetApp.Domain.Commons.Enums;

namespace VetApp.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        private Appointment(){}
        public Appointment(long animalId, long veterinarianId, DateTime startAt, 
            DateTime endAt, AppointmentPurpose appointmentPurpose, AppointmentStatus appointmentStatus)
        {
            Guard.ValidateStartAndEnd(startAt, endAt);

            // Animal = Guard.NotNull(animal, nameof(animal));
            // Veterinarian = Guard.NotNull(veterinarian, nameof(veterinarian));
            AnimalId = animalId;
            VeterinarianId = veterinarianId;

            StartAt = startAt;
            EndAt = endAt;
            AppointmentPurpose = appointmentPurpose;
            AppointmentStatus = appointmentStatus;
        }

        public long AnimalId {get; private set;}
        public Animal Animal {get; private set;}
        public long VeterinarianId {get; private set;}
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
        public void SetVeterinarianId(long veterinarianId)
            => VeterinarianId = veterinarianId;
        public void SetAppointmentPurpose(AppointmentPurpose appointmentPurpose)
            => AppointmentPurpose = appointmentPurpose;
        public void SetAppointmentSummary(string appointmentSummary)
            => AppointmentSummary = Guard.NotNull(appointmentSummary, nameof(appointmentSummary));
        public void SetAppointmentStatus(AppointmentStatus appointmentStatus)
            => AppointmentStatus = appointmentStatus;
    }
}