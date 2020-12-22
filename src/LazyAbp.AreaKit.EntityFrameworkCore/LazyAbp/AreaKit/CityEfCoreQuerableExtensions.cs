using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LazyAbp.AreaKit
{
    public static class CityEfCoreQueryableExtensions
    {
        public static IQueryable<City> IncludeDetails(this IQueryable<City> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                 .Include(x => x.Country)
                 .Include(x => x.StateProvince);
        }
    }
}