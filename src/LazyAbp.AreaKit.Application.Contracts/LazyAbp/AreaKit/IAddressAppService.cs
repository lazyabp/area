using System;
using System.Threading.Tasks;
using LazyAbp.AreaKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace LazyAbp.AreaKit
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