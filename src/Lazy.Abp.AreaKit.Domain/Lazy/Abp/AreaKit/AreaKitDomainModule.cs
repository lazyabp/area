using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaKit
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AreaKitDomainSharedModule)
    )]
    public class AreaKitDomainModule : AbpModule
    {

    }
}
