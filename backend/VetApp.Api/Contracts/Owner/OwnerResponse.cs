namespace VetApp.Api.Contracts.Owner
{
    public sealed record OwnerResponse(
        long Id,
        string FirstName, 
        string LastName, 
        string Email, 
        string PhoneNumber
    );
}