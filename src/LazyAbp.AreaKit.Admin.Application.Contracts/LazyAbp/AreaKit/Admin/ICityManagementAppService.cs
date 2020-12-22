using LazyAbp.AreaKit.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace LazyAbp.AreaKit.Admin
{
    public interface ICityManagementAppService :
        ICrudAppService<
            CityDto,
            Guid,
            GetAllCityRequestDto,
            CreateUpdateCityDto,
            CreateUpdateCityDto>
    {
    }
}
