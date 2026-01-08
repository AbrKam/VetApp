namespace VetApp.Api.Contracts.Owner
{
    public sealed record UpdateOwnerRequest(
        string FirstName, 
        string LastName, 
        string Email, 
        string PhoneNumber
    );
}