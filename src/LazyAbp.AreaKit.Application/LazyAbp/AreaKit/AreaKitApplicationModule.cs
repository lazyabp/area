using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AreaKitDomainModule),
        typeof(AreaKitApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class AreaKitApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AreaKitApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AreaKitApplicationModule>(validate: true);
            });
        }
    }
}
