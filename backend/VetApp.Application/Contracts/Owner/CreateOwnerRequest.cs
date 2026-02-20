namespace VetApp.Application.Contracts.Owner
{
    public sealed record CreateOwnerRequest(
        string? FirstName, 
        string? LastName, 
        string? Email, 
        string? PhoneNumber
    );
}