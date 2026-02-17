namespace VetApp.Api.Contracts.Veterinarian
{
    public sealed record UpdateVeterinarianRequest(
        string? FirstName, 
        string? LastName, 
        string? Email, 
        string? PhoneNumber
    );      
}