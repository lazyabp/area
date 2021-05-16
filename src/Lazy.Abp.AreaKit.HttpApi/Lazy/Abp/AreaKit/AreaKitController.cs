using Lazy.Abp.AreaKit.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.AreaKit
{
    public abstract class AreaKitController : AbpController
    {
        protected AreaKitController()
        {
            LocalizationResource = typeof(AreaKitResource);
        }
    }
}
