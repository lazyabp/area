using Lazy.Abp.AreaKit.Localization;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaKit
{
    public abstract class AreaKitAppService : ApplicationService
    {
        protected AreaKitAppService()
        {
            LocalizationResource = typeof(AreaKitResource);
            ObjectMapperContext = typeof(AreaKitApplicationModule);
        }
    }
}
