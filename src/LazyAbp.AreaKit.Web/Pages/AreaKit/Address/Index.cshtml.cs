using System.Threading.Tasks;

namespace LazyAbp.AreaKit.Web.Pages.AreaKit.Address
{
    public class IndexModel : AreaKitPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
