using VetApp.Application.Contracts.Owner;

namespace VetApp.Application.Interfaces.ServiceInterfaces
{
    public interface IOwnerService
    {
        Task<OwnerResponse> CreateAsync(CreateOwnerRequest request);
        Task<IEnumerable<OwnerResponse>> GetAllAsync();
    }
}