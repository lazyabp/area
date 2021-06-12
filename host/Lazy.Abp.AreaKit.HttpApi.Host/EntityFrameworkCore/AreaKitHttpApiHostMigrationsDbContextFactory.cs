using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Lazy.Abp.AreaKit.EntityFrameworkCore
{
    public class AreaKitHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AreaKitHttpApiHostMigrationsDbContext>
    {
        public AreaKitHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AreaKitHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("AreaKit"));

            return new AreaKitHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
