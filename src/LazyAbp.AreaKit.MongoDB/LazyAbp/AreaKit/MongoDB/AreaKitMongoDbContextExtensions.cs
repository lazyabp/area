using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace LazyAbp.AreaKit.MongoDB
{
    public static class AreaKitMongoDbContextExtensions
    {
        public static void ConfigureAreaKit(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AreaKitMongoModelBuilderConfigurationOptions(
                AreaKitDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}