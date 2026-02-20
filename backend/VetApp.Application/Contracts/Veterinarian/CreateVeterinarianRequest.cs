namespace VetApp.Application.Contracts.Veterinarian
{
    public sealed record CreateVeterinarianRequest(
        string? FirstName, 
        string? LastName, 
        string? Email, 
        string? PhoneNumber
    );   
}