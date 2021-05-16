using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Lazy.Abp.AreaKit.Addresses;
using Lazy.Abp.AreaKit.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.AreaKit
{
    public class AddressRepository : EfCoreRepository<IAreaKitDbContext, Address, Guid>, IAddressRepository
    {
        public AddressRepository(IDbContextProvider<IAreaKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<Address>> WithDetailsAsync()
        {
            return (await base.WithDetailsAsync())
                .Include(q => q.Country);
        }

        public async Task<long> GetCountAsync(
            Guid? countryId = null,
            bool? isValid = null,
            string filter = null,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetListQuery(countryId, isValid, filter);

            var totalCount = await query.LongCountAsync(GetCancellationToken(cancellationToken));

            return totalCount;
        }

        public async Task<List<Address>> GetListAsync(
            string sorting = null,
            int maxResultCount = 10,
            int skipCount = 0,
            Guid? countryId = null,
            bool? isValid = null,
            string filter = null,
            bool includeDetails = true,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetListQuery(countryId, isValid, filter);

            return await query
                .OrderBy(sorting ?? "CreationTime DESC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual async Task<IQueryable<Address>> GetListQuery(
            Guid? countryId = null,
            bool? isValid = null,
            string filter = null,
            bool includeDetails = true
        )
        {
            return (await GetQueryableAsync())
                .IncludeIf(includeDetails, q => q.Country)
                .WhereIf(countryId.HasValue, e => e.CountryId == countryId)
                .WhereIf(isValid.HasValue, e => e.IsValid == isValid)
                .WhereIf(!string.IsNullOrEmpty(filter),
                    e => false
                    || e.FullName.Contains(filter)
                    || e.State.Contains(filter)
                    || e.City.Contains(filter)
                    || e.Street.Contains(filter)
                );
        }
    }
}