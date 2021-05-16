using Lazy.Abp.AreaKit.Countries.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit.Admin.Countries
{
    public interface ICountryManagementAppService :
        ICrudAppService<
            CountryDto,
            Guid,
            CountryListAllRequestDto,
            CountryCreateUpdateDto,
            CountryCreateUpdateDto>
    {
    }
}
