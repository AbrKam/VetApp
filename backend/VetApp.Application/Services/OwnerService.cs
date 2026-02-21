using VetApp.Application.Contracts.Owner;
using VetApp.Application.Interfaces.RepositoryInterfaces;
using VetApp.Application.Interfaces.ServiceInterfaces;
using VetApp.Application.Mappings;

namespace VetApp.Application.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _repository;
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _repository = ownerRepository;
        }

        public async Task<OwnerResponse> CreateAsync(CreateOwnerRequest request)
        {
            var owner = request.CreateOwner();
            await _repository.AddAsync(owner);
            return owner.ToResponse();
        } 

        public async Task<IEnumerable<OwnerResponse>> GetAllAsync()
        {
            var owners = await _repository.GetAllAsync();
            return owners.Select(x => x.ToResponse());
        }
    }
}