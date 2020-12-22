using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LazyAbp.AreaKit.EntityFrameworkCore
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