using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using LazyAbp.AreaKit.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace LazyAbp.AreaKit
{
    public class CountryRepository : EfCoreRepository<IAreaKitDbContext, Country, Guid>, ICountryRepository
    {
        public CountryRepository(IDbContextProvider<IAreaKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<long> GetCountAsync(
                //Guid? userId = null,
                Continent? continent = null,
                bool? isActive = null,
                string filter = null,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(continent, isActive, filter, false);

            var totalCount = await query.LongCountAsync(GetCancellationToken(cancellationToken));

            return totalCount;
        }

        public async Task<List<Country>> GetListAsync(
                string sorting = null,
                int maxResultCount = 10,
                int skipCount = 0,
                //Guid? userId = null,
                Continent? continent = null,
                bool? isActive = null,
                string filter = null,
                bool includeDetails = false,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(continent, isActive, filter, includeDetails);

            return await query.IncludeDetails(includeDetails).OrderBy(sorting ?? "CreationTime DESC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<List<Country>> GetListAsync(
                string sorting = null,
                Continent? continent = null,
                bool? isActive = null,
                string filter = null,
                bool includeDetails = false,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(continent, isActive, filter, includeDetails);

            return await query
                .OrderBy(sorting ?? "CreationTime DESC")
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual IQueryable<Country> GetListQuery(
                //Guid? userId = null,
                Continent? continent = null,
                bool? isActive = null,
                string filter = null,
                bool includeDetails = true
            )
        {
            return DbSet.AsNoTracking()
                .IncludeDetails(includeDetails)
                //.WhereIf(userId.HasValue, e => false || e.UserId == userId)
                .WhereIf(continent.HasValue, e => false || e.Continent == continent)
                .WhereIf(isActive.HasValue, e => false || e.IsActive == isActive)
                .WhereIf(!string.IsNullOrEmpty(filter),
                    e => false
                    || e.Name.Contains(filter)
                    || e.DisplayName.Contains(filter)
                    || e.IsoCode3.Contains(filter)
                );
        }
    }
}