using LazyAbp.AreaKit.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LazyAbp.AreaKit.Web.Pages
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