using VetApp.Application.Contracts.Veterinarian;
using VetApp.Domain.Entities;

namespace VetApp.Application.Mappings
{
    public static class VeterinarianMappingExtension
    {
        public static VeterinarianResponse ToReponse(this Veterinarian veterinarian)
            => new VeterinarianResponse(
                veterinarian.Id,
                veterinarian.FirstName, 
                veterinarian.LastName, 
                veterinarian.Email, 
                veterinarian.PhoneNumber,
                veterinarian.Appointments.Select(x => x.Id).ToList());

        public static Veterinarian CreateVeterinarian(this CreateVeterinarianRequest request)
        => new Veterinarian(
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.PhoneNumber);

        public static void UpdateVeterinarian(this Veterinarian veterinarian, UpdateVeterinarianRequest request)
        {
            if (request.FirstName != null) veterinarian.SetFirstName(request.FirstName);
            if (request.LastName != null) veterinarian.SetLastName(request.LastName);
            if (request.Email != null) veterinarian.SetEmail(request.Email);
            if (request.PhoneNumber !=null) veterinarian.SetPhoneNumber(request.PhoneNumber);
        }
    }
}