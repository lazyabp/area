using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace LazyAbp.AreaKit.MongoDB
{
    public class AreaKitMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public AreaKitMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}