using LazyAbp.AreaKit.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(AreaKitEntityFrameworkCoreTestModule)
        )]
    public class AreaKitDomainTestModule : AbpModule
    {
        
    }
}
