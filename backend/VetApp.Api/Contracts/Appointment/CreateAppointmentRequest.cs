using VetApp.Domain.Commons.Enums;

namespace VetApp.Api.Contracts.Appointment
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