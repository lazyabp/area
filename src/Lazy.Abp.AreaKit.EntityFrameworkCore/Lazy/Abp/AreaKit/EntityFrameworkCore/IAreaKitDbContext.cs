using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Lazy.Abp.AreaKit;

namespace Lazy.Abp.AreaKit.EntityFrameworkCore
{
    [ConnectionStringName(AreaKitDbProperties.ConnectionStringName)]
    public interface IAreaKitDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Country> Countries { get; set; }
        DbSet<StateProvince> StateProvinces { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Address> Addresses { get; set; }
    }
}
