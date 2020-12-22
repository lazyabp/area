using LazyAbp.AreaKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.AreaKit
{
    [RemoteService(Name = AreaKitRemoteServiceConsts.RemoteServiceName)]
    [Area("areakit")]
    [ControllerName("Area")]
    [Route("api/areakit/areas")]
    public class AreaController : AreaKitController, IAreaAppService
    {
        private readonly IAreaAppService _service;

        public AreaController(IAreaAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("country-list")]
        public Task<ListResultDto<CountryViewDto>> GetCountriesAsync(GetCountryListRequestDto input)
        {
            return _service.GetCountriesAsync(input);
        }

        [HttpGet]
        [Route("state-province-list")]
        public Task<ListResultDto<StateProvinceViewDto>> GetStateProvincesAsync(GetStateProvinceListRequestDto input)
        {
            return _service.GetStateProvincesAsync(input);
        }

        [HttpGet]
        [Route("city-list")]
        public Task<ListResultDto<CityViewDto>> GetCitiesAsync(GetCityListRequestDto input)
        {
            return _service.GetCitiesAsync(input);
        }
    }
}
