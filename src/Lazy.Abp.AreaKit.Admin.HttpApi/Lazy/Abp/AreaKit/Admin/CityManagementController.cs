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
    [ControllerName("City")]
    [Route("api/areakit/cities/admin")]
    public class CityManagementController : AbpController, ICityManagementAppService
    {
        private readonly ICityManagementAppService _service;

        public CityManagementController(ICityManagementAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<CityDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<CityDto>> GetListAsync(GetAllCityRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<CityDto> CreateAsync(CreateUpdateCityDto input)
        {
            return _service.CreateAsync(input);
        }
        
        [HttpPut]
        [Route("{id}")]
        public Task<CityDto> UpdateAsync(Guid id, CreateUpdateCityDto input)
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
