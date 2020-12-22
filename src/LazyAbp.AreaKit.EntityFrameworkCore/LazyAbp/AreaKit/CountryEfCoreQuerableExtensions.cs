using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LazyAbp.AreaKit
{
    public static class CountryEfCoreQueryableExtensions
    {
        public static IQueryable<Country> IncludeDetails(this IQueryable<Country> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                 //.Include(x => x.StateProvinces);
                 ;
        }
    }
}