using VetApp.Api.Contracts.Appointment;
using VetApp.Domain.Entities;

namespace VetApp.Api.Mappings
{
    public static class AppointmentMappingExtension
    {
        public static AppointmentResponse ToResponse(Appointment appointment)
        {
            return new AppointmentResponse(
                appointment.Animal.Id, 
                appointment.Veterinarian.Id, 
                appointment.StartAt, 
                appointment.EndAt, 
                appointment.AppointmentPurpose, 
                appointment.AppointmentStatus
                );
        }

        public static void UpdateAppointment(Appointment appointment, UpdateAppointmentRequest request)
        {
            appointment.Reschedule(request.StartAt, request.EndAt);
            appointment.SetAppointmentPurpose(request.AppointmentPurpose); 
            appointment.SetAppointmentStatus(request.AppointmentStatus);
        }
    }
}