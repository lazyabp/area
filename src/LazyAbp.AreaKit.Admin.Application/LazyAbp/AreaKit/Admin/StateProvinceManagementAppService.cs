using LazyAbp.AreaKit.Admin.Permissions;
using LazyAbp.AreaKit.Dtos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LazyAbp.AreaKit.Admin
{
    public class StateProvinceManagementAppService : 
        CrudAppService<
            StateProvince, 
            StateProvinceDto, 
            Guid, 
            GetAllStateProvinceRequestDto, 
            CreateUpdateStateProvinceDto, 
            CreateUpdateStateProvinceDto>,
        IStateProvinceManagementAppService
    {
        protected override string GetPolicyName { get; set; } = AreaKitAdminPermissions.StateProvince.Default;
        protected override string GetListPolicyName { get; set; } = AreaKitAdminPermissions.StateProvince.Default;
        protected override string CreatePolicyName { get; set; } = AreaKitAdminPermissions.StateProvince.Create;
        protected override string UpdatePolicyName { get; set; } = AreaKitAdminPermissions.StateProvince.Update;
        protected override string DeletePolicyName { get; set; } = AreaKitAdminPermissions.StateProvince.Delete;

        private readonly IStateProvinceRepository _repository;

        public StateProvinceManagementAppService(IStateProvinceRepository repository) : base(repository)
        {
            _repository = repository;
        }

        [Authorize(AreaKitAdminPermissions.StateProvince.Default)]
        public override async Task<PagedResultDto<StateProvinceDto>> GetListAsync(GetAllStateProvinceRequestDto input)
        {
            var totalCount = await _repository.GetCountAsync(
                    input.CountryId,
                    input.IsActive,
                    input.Filter
                );

            var list = await _repository.GetListAsync(
                    input.Sorting,
                    input.MaxResultCount,
                    input.SkipCount,
                    input.CountryId,
                    input.IsActive,
                    input.Filter,
                    input.IncludeDetails
                );

            return new PagedResultDto<StateProvinceDto>(
                    totalCount,
                    ObjectMapper.Map<List<StateProvince>, List<StateProvinceDto>>(list)
                );
        }
    }
}
