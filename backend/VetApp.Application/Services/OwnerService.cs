using VetApp.Application.Contracts.Owner;
using VetApp.Application.Interfaces.RepositoryInterfaces;
using VetApp.Application.Interfaces.ServiceInterfaces;

namespace VetApp.Application.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _repository;
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _repository = ownerRepository;
        }

        // public Task<OwnerResponse> CreateAsync(CreateOwnerRequest request)
        // {
            
        // } 

        // public Task<IEnumerable<OwnerResponse>> GetAllAsync()
        // {
            
        // }
    }
}