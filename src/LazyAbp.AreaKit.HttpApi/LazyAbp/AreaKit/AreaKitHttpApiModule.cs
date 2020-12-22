using Localization.Resources.AbpUi;
using LazyAbp.AreaKit.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AreaKitApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AreaKitHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AreaKitHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AreaKitResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
