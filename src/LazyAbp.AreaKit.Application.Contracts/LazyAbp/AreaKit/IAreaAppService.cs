using LazyAbp.AreaKit.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace LazyAbp.AreaKit
{
    public interface IAreaAppService : IApplicationService, ITransientDependency
    {
        Task<ListResultDto<CountryViewDto>> GetCountriesAsync(GetCountryListRequestDto input);

        Task<ListResultDto<StateProvinceViewDto>> GetStateProvincesAsync(GetStateProvinceListRequestDto input);

        Task<ListResultDto<CityViewDto>> GetCitiesAsync(GetCityListRequestDto input);
    }
}
