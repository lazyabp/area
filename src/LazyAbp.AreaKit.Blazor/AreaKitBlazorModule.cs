using Microsoft.Extensions.DependencyInjection;
using LazyAbp.AreaKit.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace LazyAbp.AreaKit.Blazor
{
    [DependsOn(
        typeof(AreaKitHttpApiClientModule),
        typeof(AbpAutoMapperModule)
        )]
    public class AreaKitBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AreaKitBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<AreaKitBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new AreaKitMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(AreaKitBlazorModule).Assembly);
            });
        }
    }
}