using Lazy.Abp.AreaKit.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Lazy.Abp.AreaKit.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AreaKitPageModel : AbpPageModel
    {
        protected AreaKitPageModel()
        {
            LocalizationResourceType = typeof(AreaKitResource);
            ObjectMapperContext = typeof(AreaKitWebModule);
        }
    }
}