using VetApp.Domain.Entities;
using VetApp.Application.Contracts.Animal;

namespace VetApp.Application.Mappings
{
    public static class AnimalMappingExtension
    {
        public static AnimalResponse ToResponse(this Animal animal)
            => new AnimalResponse(
                animal.Id,
                animal.OwnerId,
                animal.Name,
                animal.Species,
                animal.Gender,
                animal.BirthDate);
        public static Animal CreateAnimal(this CreateAnimalRequest request)
            => new Animal(
                request.OwnerId,
                request.Name,
                request.BirthDate,
                request.Species,
                request.Breed,
                request.Gender);
        public static void UpdateAnimal(this Animal animal, UpdateAnimalRequest request)
        {
            if (request.Name != null) animal.SetName(request.Name);
        }
    }    
}