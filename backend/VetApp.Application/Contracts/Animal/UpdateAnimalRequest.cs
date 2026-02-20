using VetApp.Domain.Commons.Enums;

namespace VetApp.Application.Contracts.Animal
{
    public sealed record UpdateAnimalRequest(
        string? Name,
        AnimalSpecies Species,
        AnimalGender Gender,
        DateOnly? BirthDate 
    );
}