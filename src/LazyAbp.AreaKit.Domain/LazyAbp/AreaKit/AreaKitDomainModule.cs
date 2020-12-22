using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AreaKitDomainSharedModule)
    )]
    public class AreaKitDomainModule : AbpModule
    {

    }
}
