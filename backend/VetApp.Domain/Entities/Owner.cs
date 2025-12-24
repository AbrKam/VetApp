using VetApp.Domain.Commons;

namespace VetApp.Domain.Entities
{
    public class Owner : BaseEntity
    {
        private Owner(){}
        public Owner(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = Guard.NotNullOrWhiteSpace(firstName, nameof(firstName));
            LastName = Guard.NotNullOrWhiteSpace(lastName, nameof(lastName));
            Email = Guard.NotNullOrWhiteSpace(email, nameof(email));
            PhoneNumber = Guard.NotNullOrWhiteSpace(phoneNumber, nameof(phoneNumber));
        }

        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public string Email {get; private set;}
        public string PhoneNumber {get; private set;}
        private readonly List<Animal> _animals = new List<Animal>();
        public IReadOnlyCollection<Animal> Animals => _animals.AsReadOnly();

        public void SetFirstName(string firstName)
            => FirstName = Guard.NotNullOrWhiteSpace(firstName, nameof(firstName));
        public void SetLastName(string lastName)
            => LastName = Guard.NotNullOrWhiteSpace(lastName, nameof(lastName));
        public void SetEmail(string email)
            => Email = Guard.NotNullOrWhiteSpace(email, nameof(email));
        public void SetTelephoneNumber(string phoneNumber)
            => PhoneNumber = Guard.NotNullOrWhiteSpace(phoneNumber, nameof(phoneNumber));
        public void AddAnimal(Animal animal)
        {
            if (animal is null)
                throw new ArgumentNullException(nameof(animal));

            if (_animals.Any(x => x.Id == animal.Id))
                throw new ArgumentException("This animal is already assigned to this owner!", nameof(animal));

            _animals.Add(animal);
        }
    }
}