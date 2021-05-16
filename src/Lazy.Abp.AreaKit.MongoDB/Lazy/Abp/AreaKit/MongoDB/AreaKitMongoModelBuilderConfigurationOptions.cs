using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaKit.MongoDB
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