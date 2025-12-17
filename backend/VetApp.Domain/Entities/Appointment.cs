using VetApp.Domain.Entities;

namespace VetApp.Domain.Commons.Entities
{
    public class Appointment : BaseEntity
    {
        public Appointment(){}

        public Appointment(Animal animal, Veterinarian veterinarian, DateTime startAt, 
            DateTime endAt, AppointmentPurpose appointmentPurpose)
        {
            Animal = animal;
            Veterinarian = veterinarian;
            AppointmentPurpose = appointmentPurpose;
            StartAt = startAt;
            EndAt = endAt;
            AppointmentPurpose = appointmentPurpose;
        }

        public Animal Animal {get; private set;}
        public Veterinarian Veterinarian {get; private set;}
        public DateTime StartAt {get; private set;}
        public DateTime EndAt {get; private set;}
        public AppointmentPurpose AppointmentPurpose {get; private set;}
        public string AppointmentSummary {get; private set;}

        public void SetAnimal(Animal animal) 
            => Animal = animal;
        public void SetVeterinarian(Veterinarian veterinarian)
            => Veterinarian = veterinarian;
        public void SetAppointmentStartAtAndEndAt(DateTime startAt, DateTime endAt)
        {
            if (startAt >= endAt)
            {
                throw new ArgumentException("Appointment cannot end before it starts!");
            }
            StartAt = startAt;
            EndAt = endAt;
        }
        public void SetAppointmentPurpose(AppointmentPurpose appointmentPurpose)
            => AppointmentPurpose = appointmentPurpose;
        public void SetAppointmentSummary(string appointmentSummary)
            => AppointmentSummary = appointmentSummary;
    }
}