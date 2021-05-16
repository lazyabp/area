using Lazy.Abp.AreaKit.Cities;
using Lazy.Abp.AreaKit.Cities.Dtos;
using Lazy.Abp.AreaKit.Countries;
using Lazy.Abp.AreaKit.Countries.Dtos;
using Lazy.Abp.AreaKit.StateProvinces;
using Lazy.Abp.AreaKit.StateProvinces.Dtos;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Areas
{
    [Authorize]
    public class AreasAppService : AreaKitAppService, IAreasAppService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IStateProvinceRepository _stateProvinceRepository;
        private readonly ICityRepository _cityRepository;

        public AreasAppService(ICountryRepository countryRepository,
            IStateProvinceRepository stateProvinceRepository,
            ICityRepository cityRepository)
        {
            _countryRepository = countryRepository;
            _stateProvinceRepository = stateProvinceRepository;
            _cityRepository = cityRepository;
        }

        public async Task<ListResultDto<CountryViewDto>> GetCountriesAsync(CountryListRequestDto input)
        {
            var list = await _countryRepository.GetListAsync(null, input.Continent, true, input.Filter);

            return new ListResultDto<CountryViewDto>(
                ObjectMapper.Map<List<Country>, List<CountryViewDto>>(list)
            );
        }

        public async Task<ListResultDto<StateProvinceViewDto>> GetStateProvincesAsync(StateProvinceListRequestDto input)
        {
            var list = await _stateProvinceRepository.GetListAsync(null, input.CountryId, true, input.Filter, input.IncludeDetails);

            return new ListResultDto<StateProvinceViewDto>(
                ObjectMapper.Map<List<StateProvince>, List<StateProvinceViewDto>>(list)
            );
        }

        public async Task<ListResultDto<CityViewDto>> GetCitiesAsync(CityListRequestDto input)
        {
            var list = await _cityRepository.GetListAsync(null, null, input.StateProvinceId, true, input.Filter, input.IncludeDetails);

            return new ListResultDto<CityViewDto>(
                ObjectMapper.Map<List<City>, List<CityViewDto>>(list)
            );
        }
    }
}
