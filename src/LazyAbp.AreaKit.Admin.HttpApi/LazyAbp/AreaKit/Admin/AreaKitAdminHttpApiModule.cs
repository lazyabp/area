using LazyAbp.AreaKit.Localization;
using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit.Admin
{
    [DependsOn(
        typeof(AreaKitAdminApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AreaKitAdminHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AreaKitAdminHttpApiModule).Assembly);
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
