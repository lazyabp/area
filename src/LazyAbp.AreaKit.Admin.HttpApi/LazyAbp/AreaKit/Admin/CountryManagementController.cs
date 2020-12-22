using LazyAbp.AreaKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace LazyAbp.AreaKit.Admin
{
    [RemoteService(Name = AreaKitAdminRemoteServiceConsts.RemoteServiceName)]
    [Area("areakitadmin")]
    [ControllerName("Country")]
    [Route("api/areakit/countries/admin")]
    public class CountryManagementController : AbpController, ICountryManagementAppService
    {
        private readonly ICountryManagementAppService _service;

        public CountryManagementController(ICountryManagementAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<CountryDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<CountryDto>> GetListAsync(GetAllCountryRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<CountryDto> CreateAsync(CreateUpdateCountryDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<CountryDto> UpdateAsync(Guid id, CreateUpdateCountryDto input)
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
