using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Lazy.Abp.AreaKit
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
