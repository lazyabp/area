using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaKit.Admin
{
    [DependsOn(
        typeof(AreaKitApplicationContractsModule),
        typeof(AreaKitDomainSharedModule)
        )]
    public class AreaKitAdminApplicationContractsModule : AbpModule
    {
    }
}
