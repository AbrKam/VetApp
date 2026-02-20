namespace VetApp.Application.Contracts.Veterinarian
{
    public sealed record VeterinarianResponse(
        long Id,
        string FirstName, 
        string LastName, 
        string Email, 
        string PhoneNumber,
        IReadOnlyList<long> AppointmentIds
    );      
}