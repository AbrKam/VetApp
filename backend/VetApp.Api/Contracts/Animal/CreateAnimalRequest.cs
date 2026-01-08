using VetApp.Domain.Commons.Enums;

namespace VetApp.Api.Contracts.Animal
{
    public sealed record CreateAnimalRequest(
        Guid OwnerId,
        string Name,
        AnimalSpecies Species,
        AnimalGender Gender,
        DateOnly? BirthDate 
    );
}