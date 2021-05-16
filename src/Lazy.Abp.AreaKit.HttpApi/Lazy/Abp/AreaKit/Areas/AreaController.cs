using Lazy.Abp.AreaKit.Cities.Dtos;
using Lazy.Abp.AreaKit.Countries.Dtos;
using Lazy.Abp.AreaKit.StateProvinces.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Areas
{
    [RemoteService(Name = AreaKitRemoteServiceConsts.RemoteServiceName)]
    [Area("areakit")]
    [ControllerName("Area")]
    [Route("api/areakit/areas")]
    public class AreaController : AreaKitController, IAreasAppService
    {
        private readonly IAreasAppService _service;

        public AreaController(IAreasAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("country-list")]
        public Task<ListResultDto<CountryViewDto>> GetCountriesAsync(CountryListRequestDto input)
        {
            return _service.GetCountriesAsync(input);
        }

        [HttpGet]
        [Route("state-province-list")]
        public Task<ListResultDto<StateProvinceViewDto>> GetStateProvincesAsync(StateProvinceListRequestDto input)
        {
            return _service.GetStateProvincesAsync(input);
        }

        [HttpGet]
        [Route("city-list")]
        public Task<ListResultDto<CityViewDto>> GetCitiesAsync(CityListRequestDto input)
        {
            return _service.GetCitiesAsync(input);
        }
    }
}
