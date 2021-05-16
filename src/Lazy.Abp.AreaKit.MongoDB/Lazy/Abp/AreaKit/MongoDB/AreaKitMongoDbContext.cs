using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaKit.MongoDB
{
    [ConnectionStringName(AreaKitDbProperties.ConnectionStringName)]
    public class AreaKitMongoDbContext : AbpMongoDbContext, IAreaKitMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAreaKit();
        }
    }
}