using Lazy.Abp.AreaKit.Dtos;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit
{
    [Authorize]
    public class AreasAppService : ApplicationService, IAreasAppService
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

        public async Task<ListResultDto<CountryViewDto>> GetCountriesAsync(GetCountryListRequestDto input)
        {
            var list = await _countryRepository.GetListAsync(null, input.Continent, true, input.Filter);

            return new ListResultDto<CountryViewDto>(
                ObjectMapper.Map<List<Country>, List<CountryViewDto>>(list)
            );
        }

        public async Task<ListResultDto<StateProvinceViewDto>> GetStateProvincesAsync(GetStateProvinceListRequestDto input)
        {
            var list = await _stateProvinceRepository.GetListAsync(null, input.CountryId, true, input.Filter, input.IncludeDetails);

            return new ListResultDto<StateProvinceViewDto>(
                ObjectMapper.Map<List<StateProvince>, List<StateProvinceViewDto>>(list)
            );
        }

        public async Task<ListResultDto<CityViewDto>> GetCitiesAsync(GetCityListRequestDto input)
        {
            var list = await _cityRepository.GetListAsync(null, null, input.StateProvinceId, true, input.Filter, input.IncludeDetails);

            return new ListResultDto<CityViewDto>(
                ObjectMapper.Map<List<City>, List<CityViewDto>>(list)
            );
        }
    }
}
