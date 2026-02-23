using VetApp.Application.Contracts.Owner;
using VetApp.Domain.Entities;

namespace VetApp.Application.Interfaces.ServiceInterfaces
{
    public interface IOwnerService
    {
        Task<OwnerResponse> CreateAsync(CreateOwnerRequest request);
        Task<IEnumerable<OwnerResponse>> GetAllAsync();
        Task<OwnerResponse?> UpdateAsync(long id, UpdateOwnerRequest request);
        Task<OwnerResponse?> DeleteAsync(long id);
    }
}