using VetApp.Domain.Commons.Enums;

namespace VetApp.Application.Contracts.Appointment
{
    public sealed record CreateAppointmentRequest(
        long AnimalId, 
        long VeterinarianId, 
        DateTime StartAt, 
        DateTime EndAt, 
        AppointmentPurpose AppointmentPurpose, 
        AppointmentStatus AppointmentStatus
    );
}