using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.AreaKit.EntityFrameworkCore
{
    public class AreaKitHttpApiHostMigrationsDbContext : AbpDbContext<AreaKitHttpApiHostMigrationsDbContext>
    {
        public AreaKitHttpApiHostMigrationsDbContext(DbContextOptions<AreaKitHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAreaKit();
        }
    }
}
