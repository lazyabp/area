using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace LazyAbp.AreaKit.MongoDB
{
    [ConnectionStringName(AreaKitDbProperties.ConnectionStringName)]
    public interface IAreaKitMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
