namespace VetApp.Application.Contracts.Veterinarian
{
    public sealed record UpdateVeterinarianRequest(
        string? FirstName, 
        string? LastName, 
        string? Email, 
        string? PhoneNumber
    );      
}