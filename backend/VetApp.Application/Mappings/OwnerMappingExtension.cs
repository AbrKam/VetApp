using VetApp.Application.Contracts.Owner;
using VetApp.Domain.Entities;

namespace VetApp.Application.Mappings
{
    public static class OwnerMappingExtension
    {
        public static OwnerResponse ToResponse(this Owner owner)
        => new OwnerResponse(
                owner.Id,
                owner.FirstName, 
                owner.LastName, 
                owner.Email, 
                owner.PhoneNumber,
                owner.Animals.Select(x => x.Id).ToList());
        public static Owner CreateOwner(this CreateOwnerRequest request)
            => new Owner(
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.PhoneNumber);
        public static void UpdateOwner(this Owner owner, UpdateOwnerRequest request)
        {
            if (request.FirstName != null) owner.SetFirstName(request.FirstName);
            if (request.LastName != null) owner.SetLastName(request.LastName);
            if (request.Email != null) owner.SetEmail(request.Email);
            if (request.PhoneNumber != null) owner.SetPhoneNumber(request.PhoneNumber);
        }
    }
}