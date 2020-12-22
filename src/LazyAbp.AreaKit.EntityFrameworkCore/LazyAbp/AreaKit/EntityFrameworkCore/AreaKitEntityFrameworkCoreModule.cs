using LazyAbp.AreaKit;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LazyAbp.AreaKit.EntityFrameworkCore
{
    [DependsOn(
        typeof(AreaKitDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class AreaKitEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AreaKitDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Country, CountryRepository>();
                options.AddRepository<StateProvince, StateProvinceRepository>();
                options.AddRepository<City, CityRepository>();
                options.AddRepository<Address, AddressRepository>();
            });
        }
    }
}