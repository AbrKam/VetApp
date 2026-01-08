namespace VetApp.Api.Contracts.Veterinarian
{
    public sealed record VeterinarianResponse(
        long Id,
        string FirstName, 
        string LastName, 
        string Email, 
        string PhoneNumber
    );      
}