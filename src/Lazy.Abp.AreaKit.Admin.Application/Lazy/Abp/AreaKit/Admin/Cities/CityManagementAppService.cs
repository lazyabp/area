using Lazy.Abp.AreaKit.Admin.Permissions;
using Lazy.Abp.AreaKit.Cities;
using Lazy.Abp.AreaKit.Cities.Dtos;
using Lazy.Abp.AreaKit.StateProvinces;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit.Admin.Cities
{
    public class CityManagementAppService : 
        CrudAppService<
            City, 
            CityDto,
            Guid, 
            CityListAllRequestDto, 
            CityCreateUpdateDto, 
            CityCreateUpdateDto>,
        ICityManagementAppService
    {
        protected override string GetPolicyName { get; set; } = AreaKitAdminPermissions.City.Default;
        protected override string GetListPolicyName { get; set; } = AreaKitAdminPermissions.City.Default;
        protected override string CreatePolicyName { get; set; } = AreaKitAdminPermissions.City.Create;
        protected override string UpdatePolicyName { get; set; } = AreaKitAdminPermissions.City.Update;
        protected override string DeletePolicyName { get; set; } = AreaKitAdminPermissions.City.Delete;

        private readonly ICityRepository _repository;
        private readonly IStateProvinceRepository _stateProvinceRepository;

        public CityManagementAppService(ICityRepository repository,
            IStateProvinceRepository stateProvinceRepository) 
            : base(repository)
        {
            _repository = repository;
            _stateProvinceRepository = stateProvinceRepository;
        }

        [Authorize(AreaKitAdminPermissions.City.Create)]
        public override async Task<CityDto> CreateAsync(CityCreateUpdateDto input)
        {
            var stateProvince = await _stateProvinceRepository.GetAsync(input.StateProvinceId);
            var city = new City(GuidGenerator.Create(), stateProvince.CountryId, input.StateProvinceId,
                input.Name, input.DisplayName, input.Abbreviation, input.IsActive, input.DisplayOrder);
            
            await _repository.InsertAsync(city);

            return ObjectMapper.Map<City, CityDto>(city);
        }

        [Authorize(AreaKitAdminPermissions.City.Update)]
        public override async Task<CityDto> UpdateAsync(Guid id, CityCreateUpdateDto input)
        {
            var stateProvince = await _stateProvinceRepository.GetAsync(input.StateProvinceId);
            var city = await _repository.GetAsync(id);
            city.Update(stateProvince.CountryId, input.StateProvinceId, input.Name,
                input.DisplayName, input.Abbreviation, input.IsActive, input.DisplayOrder);

            await _repository.UpdateAsync(city);

            return ObjectMapper.Map<City, CityDto>(city);
        }

        [Authorize(AreaKitAdminPermissions.City.Default)]
        public override async Task<PagedResultDto<CityDto>> GetListAsync(CityListAllRequestDto input)
        {
            var totalCount = await _repository.GetCountAsync(
                input.CountryId,
                input.StateProvinceId,
                input.IsActive,
                input.Filter
            );

            var list = await _repository.GetListAsync(
                input.Sorting,
                input.MaxResultCount,
                input.SkipCount,
                input.CountryId,
                input.StateProvinceId,
                input.IsActive,
                input.Filter,
                input.IncludeDetails
            );

            return new PagedResultDto<CityDto>(
                totalCount,
                ObjectMapper.Map<List<City>, List<CityDto>>(list)
            );
        }
    }
}
