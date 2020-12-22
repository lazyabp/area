using LazyAbp.AreaKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LazyAbp.AreaKit
{
    public abstract class AreaKitController : AbpController
    {
        protected AreaKitController()
        {
            LocalizationResource = typeof(AreaKitResource);
        }
    }
}
