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
        public async Task<OwnerResponse?> UpdateAsync(long id, UpdateOwnerRequest request)
        {
            var owner = await _repository.GetByIdAsync(id);
            if (owner == null) return null;
            
            owner.UpdateOwner(request);

            await _repository.UpdateAsync(owner);

            return owner.ToResponse();
        }
        public async Task<OwnerResponse?> DeleteAsync(long id)
        {
            var owner = await _repository.GetByIdAsync(id);
            if (owner == null) return null;

            await _repository.RemoveAsync(owner);
            return owner.ToResponse();
        }
    }
}