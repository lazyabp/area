using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Lazy.Abp.AreaKit.Countries.Dtos;
using Lazy.Abp.AreaKit.StateProvinces.Dtos;
using Lazy.Abp.AreaKit.Cities.Dtos;

namespace Lazy.Abp.AreaKit.Areas
{
    public interface IAreasAppService : IApplicationService, ITransientDependency
    {
        Task<ListResultDto<CountryViewDto>> GetCountriesAsync(CountryListRequestDto input);

        Task<ListResultDto<StateProvinceViewDto>> GetStateProvincesAsync(StateProvinceListRequestDto input);

        Task<ListResultDto<CityViewDto>> GetCitiesAsync(CityListRequestDto input);
    }
}
