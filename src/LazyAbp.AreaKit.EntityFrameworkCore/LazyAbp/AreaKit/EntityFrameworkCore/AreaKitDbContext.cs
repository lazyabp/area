using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using LazyAbp.AreaKit;

namespace LazyAbp.AreaKit.EntityFrameworkCore
{
    [ConnectionStringName(AreaKitDbProperties.ConnectionStringName)]
    public class AreaKitDbContext : AbpDbContext<AreaKitDbContext>, IAreaKitDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Country> Countries { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public AreaKitDbContext(DbContextOptions<AreaKitDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAreaKit();
        }
    }
}
