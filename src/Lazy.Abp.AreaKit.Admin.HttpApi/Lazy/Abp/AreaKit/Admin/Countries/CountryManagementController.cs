using Lazy.Abp.AreaKit.Countries.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.AreaKit.Admin.Countries
{
    [RemoteService(Name = AreaKitAdminRemoteServiceConsts.RemoteServiceName)]
    [Area("areakit")]
    [ControllerName("Country")]
    [Route("api/areakit/countries/management")]
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
        public Task<PagedResultDto<CountryDto>> GetListAsync(CountryListAllRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<CountryDto> CreateAsync(CountryCreateUpdateDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<CountryDto> UpdateAsync(Guid id, CountryCreateUpdateDto input)
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
