using VetApp.Domain.Commons.Enums;

namespace VetApp.Application.Contracts.Animal
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