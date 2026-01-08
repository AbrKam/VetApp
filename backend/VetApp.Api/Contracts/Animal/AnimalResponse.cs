using VetApp.Domain.Commons.Enums;

namespace VetApp.Api.Contracts.Animal
{
    public sealed record AnimalReponse(
        long Id,
        Guid OwnerId,
        string Name,
        AnimalSpecies Species,
        AnimalGender Gender,
        DateOnly? BirthDate 
    )
}