using System;
using LazyAbp.AreaKit.Permissions;
using LazyAbp.AreaKit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Users;
using Volo.Abp;

namespace LazyAbp.AreaKit
{
    public class AddressAppService : AreaKitAppService, IAddressAppService, ITransientDependency
    {
        private readonly IAddressRepository _repository;
        private readonly ICityRepository _cityRepository;
        //private readonly IStateProvinceRepository _stateProvinceRepository;
        //private readonly ICountryRepository _countryRepository;

        public AddressAppService(IAddressRepository repository,
            //ICountryRepository countryRepository,
            //IStateProvinceRepository stateProvinceRepository,
            ICityRepository cityRepository)
        {
            _repository = repository;
            _cityRepository = cityRepository;
            //_stateProvinceRepository = stateProvinceRepository;
            //_countryRepository = countryRepository;
        }

        public async Task<AddressDto> GetAsync(Guid id)
        {
            var address = await _repository.GetAsync(id);
            if (address.UserId != CurrentUser.GetId())
                throw new UserFriendlyException(L["NoPermissions"]);

            return ObjectMapper.Map<Address, AddressDto>(address);
        }

        public async Task<PagedResultDto<AddressDto>> GetListAsync(GetAllAddressRequestDto input)
        {
            var totalCount = await _repository.GetCountAsync(
                    input.UserId, 
                    input.CountryId, 
                    input.StateProvinceId, 
                    input.CityId, 
                    input.IsDefault, 
                    input.Filter
                );

            var list = await _repository.GetListAsync(
                    input.Sorting,
                    input.MaxResultCount,
                    input.SkipCount,
                    input.UserId,
                    input.CountryId,
                    input.StateProvinceId,
                    input.CityId,
                    input.IsDefault,
                    input.Filter
                );

            return new PagedResultDto<AddressDto>(
                    totalCount,
                    ObjectMapper.Map<List<Address>, List<AddressDto>>(list) 
                );
        }

        public async Task<AddressDto> CreateAsync(CreateUpdateAddressDto input)
        {
            var city = await _cityRepository.GetAsync(input.CityId);

            var address = new Address(GuidGenerator.Create(), CurrentUser.GetId(), input.FirstName, input.LastName, input.FullName,
                input.Company, city.CountryId, city.StateProvinceId, input.CityId, input.County, input.Address1, input.Address2,
                input.PostCode, input.Email, input.PhoneNumber, input.FaxNumber, input.Tag, input.IsDefault, input.DisplayOrder);

            address = await _repository.InsertAsync(address);

            return ObjectMapper.Map<Address, AddressDto>(address);
        }

        public async Task<AddressDto> UpdateAsync(Guid id, CreateUpdateAddressDto input)
        {
            var address = await _repository.GetAsync(id);
            if (address.UserId != CurrentUser.GetId())
                throw new UserFriendlyException(L["NoPermissions"]);

            var city = await _cityRepository.GetAsync(input.CityId);

            address.Update(input.FirstName, input.LastName, input.FullName, input.Company, city.CountryId, city.StateProvinceId,
                input.CityId, input.County, input.Address1, input.Address2, input.PostCode, input.Email, input.PhoneNumber,
                input.FaxNumber, input.Tag, input.IsDefault, input.DisplayOrder);

            address = await _repository.UpdateAsync(address);

            return ObjectMapper.Map<Address, AddressDto>(address);
        }

        public async Task DeleteAsync(Guid id)
        {
            var address = await _repository.GetAsync(id);
            if (address.UserId != CurrentUser.GetId())
                throw new UserFriendlyException(L["NoPermissions"]);

            await _repository.DeleteAsync(address);
        }
    }
}
