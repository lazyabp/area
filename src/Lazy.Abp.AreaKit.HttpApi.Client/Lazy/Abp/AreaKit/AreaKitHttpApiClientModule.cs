using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaKit
{
    [DependsOn(
        typeof(AreaKitApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AreaKitHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "AreaKit";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AreaKitApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
