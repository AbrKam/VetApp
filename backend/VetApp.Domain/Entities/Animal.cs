using VetApp.Domain.Commons;
using VetApp.Domain.Commons.Enums;

namespace VetApp.Domain.Entities
{
    public class Animal: BaseEntity
    {
        public string Name {get; protected set;}
        public AnimalSpecies Species {get; protected set;}
        public AnimalGender Gender {get; protected set;}

    }
}
