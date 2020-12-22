using LazyAbp.AreaKit.Localization;
using Volo.Abp.Application.Services;

namespace LazyAbp.AreaKit
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
