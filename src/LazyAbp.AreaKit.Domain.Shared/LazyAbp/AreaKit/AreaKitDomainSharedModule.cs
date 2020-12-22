using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using LazyAbp.AreaKit.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace LazyAbp.AreaKit
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class AreaKitDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AreaKitDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AreaKitResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/LazyAbp/AreaKit/Localization");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("AreaKit", typeof(AreaKitResource));
            });
        }
    }
}
