using VetApp.Domain.Commons.Enums;

namespace VetApp.Api.Contracts.Animal
{
    public sealed record AnimalResponse(
        long Id,
        long OwnerId,
        string? Name,
        AnimalSpecies Species,
        AnimalGender Gender,
        DateOnly? BirthDate 
    );
}