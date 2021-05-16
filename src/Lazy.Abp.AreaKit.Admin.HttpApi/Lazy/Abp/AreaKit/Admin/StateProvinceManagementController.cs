using Lazy.Abp.AreaKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.AreaKit.Admin
{
    [RemoteService(Name = AreaKitAdminRemoteServiceConsts.RemoteServiceName)]
    [Area("areakitadmin")]
    [ControllerName("StateProvince")]
    [Route("api/areakit/state-provinces/admin")]
    public class StateProvinceManagementController : AbpController, IStateProvinceManagementAppService
    {
        private readonly IStateProvinceManagementAppService _service;

        public StateProvinceManagementController(IStateProvinceManagementAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<StateProvinceDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<StateProvinceDto>> GetListAsync(GetAllStateProvinceRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<StateProvinceDto> CreateAsync(CreateUpdateStateProvinceDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<StateProvinceDto> UpdateAsync(Guid id, CreateUpdateStateProvinceDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}
