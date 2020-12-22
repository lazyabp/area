using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AreaKitHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AreaKitConsoleApiClientModule : AbpModule
    {
        
    }
}
