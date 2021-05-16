using Lazy.Abp.AreaKit.StateProvinces.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit.Admin.StateProvinces
{
    public interface IStateProvinceManagementAppService :
        ICrudAppService<
            StateProvinceDto,
            Guid,
            StateProvinceListAllRequestDto,
            StateProvinceCreateUpdateDto,
            StateProvinceCreateUpdateDto>
    {
    }
}
