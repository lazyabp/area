using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AreaKitApplicationModule),
        typeof(AreaKitDomainTestModule)
        )]
    public class AreaKitApplicationTestModule : AbpModule
    {

    }
}
