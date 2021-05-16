using Lazy.Abp.AreaKit.Admin.Permissions;
using Lazy.Abp.AreaKit.Dtos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit.Admin
{
    public class CountryManagementAppService :
        CrudAppService<
            Country, 
            CountryDto, 
            Guid, 
            GetAllCountryRequestDto, 
            CreateUpdateCountryDto, 
            CreateUpdateCountryDto>,
        ICountryManagementAppService
    {
        protected override string GetPolicyName { get; set; } = AreaKitAdminPermissions.Country.Default;
        protected override string GetListPolicyName { get; set; } = AreaKitAdminPermissions.Country.Default;
        protected override string CreatePolicyName { get; set; } = AreaKitAdminPermissions.Country.Create;
        protected override string UpdatePolicyName { get; set; } = AreaKitAdminPermissions.Country.Update;
        protected override string DeletePolicyName { get; set; } = AreaKitAdminPermissions.Country.Delete;

        private readonly ICountryRepository _repository;

        public CountryManagementAppService(ICountryRepository repository) : base(repository)
        {
            _repository = repository;
        }

        [Authorize(AreaKitAdminPermissions.Country.Default)]
        public override async Task<PagedResultDto<CountryDto>> GetListAsync(GetAllCountryRequestDto input)
        {
            var totalCount = await _repository.GetCountAsync(
                input.Continent,
                input.IsActive,
                input.Filter
            );

            var list = await _repository.GetListAsync(
                input.Sorting,
                input.MaxResultCount,
                input.SkipCount,
                input.Continent,
                input.IsActive,
                input.Filter
            );

            return new PagedResultDto<CountryDto>(
                totalCount,
                ObjectMapper.Map<List<Country>, List<CountryDto>>(list)
            );
        }
    }
}
