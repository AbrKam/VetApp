using VetApp.Domain.Entities;
using VetApp.Api.Contracts.Animal;

namespace VetApp.Api.Mappings
{
    public static class AnimalMappingExtension
    {
        public static AnimalResponse ToResponse(Animal animal)
        {
            return new AnimalResponse(
                animal.Id,
                animal.Owner.Id,
                animal.Name,
                animal.Species,
                animal.Gender,
                animal.BirthDate
            );
        }

        public static void UpdateAnimal(Animal animal, UpdateAnimalRequest request)
        {
            if (request.Name != null) animal.SetName(request.Name);
        }
    }    
}