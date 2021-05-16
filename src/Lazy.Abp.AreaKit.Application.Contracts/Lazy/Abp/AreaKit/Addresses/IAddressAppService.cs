using System;
using System.Threading.Tasks;
using Lazy.Abp.AreaKit.Addresses.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Lazy.Abp.AreaKit.Addresses
{
    public interface IAddressAppService : IApplicationService, ITransientDependency
    {
        Task<AddressDto> GetAsync(Guid id);

        Task<AddressDto> CreateAsync(AddressCreateUpdateDto input);

        Task<AddressDto> UpdateAsync(Guid id, AddressCreateUpdateDto input);

        Task<PagedResultDto<AddressDto>> GetListAsync(AddressListRequestDto input);

        Task DeleteAsync(Guid id);
    }
}