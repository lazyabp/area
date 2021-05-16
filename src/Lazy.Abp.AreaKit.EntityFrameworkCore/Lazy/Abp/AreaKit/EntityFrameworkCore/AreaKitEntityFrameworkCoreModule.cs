using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Lazy.Abp.AreaKit.Countries;
using Lazy.Abp.AreaKit.StateProvinces;
using Lazy.Abp.AreaKit.Cities;
using Lazy.Abp.AreaKit.Addresses;

namespace Lazy.Abp.AreaKit.EntityFrameworkCore
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
