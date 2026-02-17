using VetApp.Api.Contracts.Appointment;
using VetApp.Domain.Entities;

namespace VetApp.Api.Mappings
{
    public static class AppointmentMappingExtension
    {
        public static AppointmentResponse ToResponse(Appointment appointment)
            => new AppointmentResponse(
                appointment.AnimalId, 
                appointment.VeterinarianId, 
                appointment.StartAt, 
                appointment.EndAt, 
                appointment.AppointmentPurpose, 
                appointment.AppointmentStatus);
        public static Appointment CreateAppointment(CreateAppointmentRequest request)
            => new Appointment(
                request.AnimalId,
                request.VeterinarianId,
                request.StartAt,
                request.EndAt,
                request.AppointmentPurpose,
                request.AppointmentStatus);
        public static void UpdateAppointment(Appointment appointment, UpdateAppointmentRequest request)
        {
            appointment.Reschedule(request.StartAt, request.EndAt);
            appointment.SetAppointmentPurpose(request.AppointmentPurpose); 
            appointment.SetAppointmentStatus(request.AppointmentStatus);
        }
    }
}