using Lazy.Abp.AreaKit.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit.Admin
{
    public interface ICountryManagementAppService :
        ICrudAppService<
            CountryDto,
            Guid,
            GetAllCountryRequestDto,
            CreateUpdateCountryDto,
            CreateUpdateCountryDto>
    {
    }
}
