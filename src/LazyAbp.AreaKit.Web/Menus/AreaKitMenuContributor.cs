using LazyAbp.AreaKit.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace LazyAbp.AreaKit.Web.Menus
{
    public class AreaKitMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<AreaKitResource>>();

            context.Menu.AddItem(
                new ApplicationMenuItem(AreaKitMenus.Area, l["Menu:Area"])
                    .AddItem(new ApplicationMenuItem(AreaKitMenus.Country, l["Menu:Country"], url: "/AreaKit/Country"))
                    .AddItem(new ApplicationMenuItem(AreaKitMenus.StateProvince, l["Menu:StateProvince"], url: "/AreaKit/StateProvince"))
                    .AddItem(new ApplicationMenuItem(AreaKitMenus.City, l["Menu:City"], url: "/AreaKit/City"))
                    .AddItem(new ApplicationMenuItem(AreaKitMenus.Address, l["Menu:Address"], url: "/AreaKit/Address"))
            );

            return Task.CompletedTask;
        }
    }
}