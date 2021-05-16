using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.AreaKit.EntityFrameworkCore
{
    public class AreaKitModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AreaKitModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}