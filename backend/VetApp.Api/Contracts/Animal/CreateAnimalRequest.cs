using VetApp.Domain.Commons.Enums;

namespace VetApp.Api.Contracts.Animal
{
    public sealed record CreateAnimalRequest(
        long OwnerId,
        string Name,
        DateOnly BirthDate,
        AnimalSpecies Species,
        string Breed,
        AnimalGender Gender
    );
}