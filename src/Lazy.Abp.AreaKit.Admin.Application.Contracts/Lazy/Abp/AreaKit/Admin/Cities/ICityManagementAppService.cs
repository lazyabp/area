using Lazy.Abp.AreaKit.Cities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit.Admin.Cities
{
    public interface ICityManagementAppService :
        ICrudAppService<
            CityDto,
            Guid,
            CityListAllRequestDto,
            CityCreateUpdateDto,
            CityCreateUpdateDto>
    {
    }
}
