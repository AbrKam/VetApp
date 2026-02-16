namespace VetApp.Api.Contracts.Veterinarian
{
    public sealed record CreateVeterinarianRequest(
        string? FirstName, 
        string? LastName, 
        string? Email, 
        string? PhoneNumber
    );   
}