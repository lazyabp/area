using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Lazy.Abp.AreaKit.Cities;
using Lazy.Abp.AreaKit.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.AreaKit
{
    public class CityRepository : EfCoreRepository<IAreaKitDbContext, City, Guid>, ICityRepository
    {
        public CityRepository(IDbContextProvider<IAreaKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<City>> WithDetailsAsync()
        {
            return (await base.WithDetailsAsync())
                //.Include(q => q.Country)
                .Include(q => q.StateProvince).ThenInclude(x => x.Country);
        }

        public async Task<long> GetCountAsync(
                //Guid? userId = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                bool? isActive = null,
                string filter = null,
                CancellationToken cancellationToken = default
            )
        {
            var query = await GetListQuery(countryId, stateProvinceId, isActive, filter, false);

            return await query
                .LongCountAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<List<City>> GetListAsync(
                string sorting = null,
                int maxResultCount = 10,
                int skipCount = 0,
                //Guid? userId = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                bool? isActive = null,
                string filter = null,
                bool includeDetails = true,
                CancellationToken cancellationToken = default
            )
        {
            var query = await GetListQuery(countryId, stateProvinceId, isActive, filter, includeDetails);

            return await query
                .OrderBy(sorting ?? "CreationTime DESC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        public virtual async Task<List<City>> GetListAsync(
            string sorting = null,
            Guid? countryId = null,
            Guid? stateProvinceId = null,
            bool? isActive = null,
            string filter = null,
            bool includeDetails = true,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetListQuery(countryId, stateProvinceId, isActive, filter, includeDetails);

            return await query
                .OrderBy(sorting ?? "CreationTime DESC")
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual async Task<IQueryable<City>> GetListQuery(
            //Guid? userId = null,
            Guid? countryId = null,
            Guid? stateProvinceId = null,
            bool? isActive = null,
            string filter = null,
            bool includeDetails = true
        )
        {
            return (await GetQueryableAsync())
                //.IncludeIf(includeDetails, q => q.Country)
                .IncludeIf(includeDetails, q => q.StateProvince)
                //.WhereIf(userId.HasValue, e => false || e.UserId == userId)
                .WhereIf(countryId.HasValue, e => false || e.CountryId == countryId)
                .WhereIf(stateProvinceId.HasValue, e => false || e.StateProvinceId == stateProvinceId)
                .WhereIf(isActive.HasValue, e => false || e.IsActive == isActive)
                .WhereIf(!string.IsNullOrEmpty(filter),
                    e => false
                    || e.Name.Contains(filter)
                    || e.DisplayName.Contains(filter)
                    || e.Abbreviation.Contains(filter)
                );
        }
    }
}