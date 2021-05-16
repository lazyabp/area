using System;
using System.Threading.Tasks;
using Lazy.Abp.AreaKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace Lazy.Abp.AreaKit
{
    public interface IAddressAppService : IApplicationService, ITransientDependency
    {
        Task<AddressDto> GetAsync(Guid id);

        Task<AddressDto> CreateAsync(CreateUpdateAddressDto input);

        Task<AddressDto> UpdateAsync(Guid id, CreateUpdateAddressDto input);

        Task<PagedResultDto<AddressDto>> GetListAsync(GetAllAddressRequestDto input);

        Task DeleteAsync(Guid id);
    }
}