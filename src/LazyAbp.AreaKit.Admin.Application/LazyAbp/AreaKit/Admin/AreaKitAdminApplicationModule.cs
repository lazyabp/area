using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit.Admin
{
    [DependsOn(
        typeof(AreaKitDomainModule),
        typeof(AreaKitAdminApplicationContractsModule),
        typeof(AbpCachingModule),
        typeof(AbpAutoMapperModule))]
    public class AreaKitAdminApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AreaKitAdminApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<AreaKitAdminApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
