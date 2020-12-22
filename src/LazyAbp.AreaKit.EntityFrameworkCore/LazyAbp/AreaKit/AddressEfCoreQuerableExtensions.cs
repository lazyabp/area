using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LazyAbp.AreaKit
{
    public static class AddressEfCoreQueryableExtensions
    {
        public static IQueryable<Address> IncludeDetails(this IQueryable<Address> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                 .Include(x => x.Country)
                 .Include(x => x.StateProvince)
                 .Include(x => x.City);
        }
    }
}