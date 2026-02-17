using VetApp.Api.Contracts.Veterinarian;
using VetApp.Domain.Entities;

namespace VetApp.Api.Mappings
{
    public static class VeterinarianMappingExtension
    {
        public static VeterinarianResponse ToReponse(Veterinarian veterinarian)
            => new VeterinarianResponse(
                veterinarian.Id,
                veterinarian.FirstName, 
                veterinarian.LastName, 
                veterinarian.Email, 
                veterinarian.PhoneNumber,
                veterinarian.Appointments.Select(x => x.Id).ToList());

        public static Veterinarian CreateVeterinarian(CreateVeterinarianRequest request)
        => new Veterinarian(
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.PhoneNumber);

        public static void UpdateVeterinarian(Veterinarian veterinarian, UpdateVeterinarianRequest request)
        {
            if (request.FirstName != null) veterinarian.SetFirstName(request.FirstName);
            if (request.LastName != null) veterinarian.SetLastName(request.LastName);
            if (request.Email != null) veterinarian.SetEmail(request.Email);
            if (request.PhoneNumber !=null) veterinarian.SetPhoneNumber(request.PhoneNumber);
        }
    }
}