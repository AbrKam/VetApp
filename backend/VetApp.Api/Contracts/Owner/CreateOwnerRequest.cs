namespace VetApp.Api.Contracts.Owner
{
    public sealed record CreateOwnerRequest(
        string? FirstName, 
        string? LastName, 
        string? Email, 
        string? PhoneNumber
    );
}