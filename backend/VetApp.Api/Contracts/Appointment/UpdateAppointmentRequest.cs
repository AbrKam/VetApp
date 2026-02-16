using VetApp.Domain.Commons.Enums;

namespace VetApp.Api.Contracts.Appointment
{
    public sealed record UpdateAppointmentRequest(
        DateTime? StartAt, 
        DateTime? EndAt, 
        AppointmentPurpose? AppointmentPurpose, 
        AppointmentStatus? AppointmentStatus
    );
}