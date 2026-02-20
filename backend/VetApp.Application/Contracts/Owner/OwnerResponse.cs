namespace VetApp.Application.Contracts.Owner
{
    public sealed record OwnerResponse(
        long Id,
        string FirstName, 
        string LastName, 
        string Email, 
        string PhoneNumber,
        IReadOnlyList<long> AnimalIds
    );
}