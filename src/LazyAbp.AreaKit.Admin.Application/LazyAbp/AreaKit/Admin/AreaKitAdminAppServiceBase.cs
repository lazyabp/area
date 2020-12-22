using LazyAbp.AreaKit.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace LazyAbp.AreaKit.Admin
{
    public abstract class AreaKitAdminAppServiceBase : ApplicationService
    {
        protected AreaKitAdminAppServiceBase()
        {
            ObjectMapperContext = typeof(AreaKitAdminApplicationModule);
            LocalizationResource = typeof(AreaKitResource);
        }
    }
}
