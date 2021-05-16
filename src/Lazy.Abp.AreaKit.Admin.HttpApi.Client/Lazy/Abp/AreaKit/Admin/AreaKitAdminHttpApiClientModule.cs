using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaKit.Admin
{
    [DependsOn(
        typeof(AreaKitAdminApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AreaKitAdminHttpApiClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(typeof(AreaKitAdminApplicationContractsModule).Assembly,
                AreaKitAdminRemoteServiceConsts.RemoteServiceName);
        }
    }
}
