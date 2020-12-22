using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AreaKitDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AreaKitApplicationContractsModule : AbpModule
    {

    }
}
