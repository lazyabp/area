using Lazy.Abp.AreaKit.Addresses.Dtos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace Lazy.Abp.AreaKit.Addresses
{
    [Authorize]
    public class AddressAppService : AreaKitAppService, IAddressAppService, ITransientDependency
    {
        private readonly IAddressRepository _repository;

        public AddressAppService(IAddressRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddressDto> GetAsync(Guid id)
        {
            var address = await _repository.GetAsync(id);

            return ObjectMapper.Map<Address, AddressDto>(address);
        }

        public async Task<PagedResultDto<AddressDto>> GetListAsync(AddressListRequestDto input)
        {
            var totalCount = await _repository.GetCountAsync(
                null, 
                input.IsValid,
                input.Filter
            );

            var list = await _repository.GetListAsync(
                input.Sorting,
                input.MaxResultCount,
                input.SkipCount,
                null,
                input.IsValid,
                input.Filter
            );

            return new PagedResultDto<AddressDto>(
                totalCount,
                ObjectMapper.Map<List<Address>, List<AddressDto>>(list) 
            );
        }

        public async Task<AddressDto> CreateAsync(AddressCreateUpdateDto input)
        {
            var address = new Address(GuidGenerator.Create(), CurrentUser.TenantId, input.CountryIsoCode,
                input.FirstName, input.LastName, input.FullName, input.StateProvince, input.City, input.Street, input.Position, input.IsValid);

            address = await _repository.InsertAsync(address);

            return ObjectMapper.Map<Address, AddressDto>(address);
        }

        public async Task<AddressDto> UpdateAsync(Guid id, AddressCreateUpdateDto input)
        {
            var address = await _repository.GetAsync(id);

            address.Update(input.FirstName, input.LastName, input.FullName, input.StateProvince, input.City, input.Street, input.Position, input.IsValid);

            address = await _repository.UpdateAsync(address);

            return ObjectMapper.Map<Address, AddressDto>(address);
        }

        public async Task DeleteAsync(Guid id)
        {
            var address = await _repository.GetAsync(id);

            await _repository.DeleteAsync(address);
        }
    }
}
