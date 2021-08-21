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

        public async Task<long> GetCountAsync(
            string countryIsoCode = null,
            bool? isValid = null,
            string filter = null,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetListQuery(countryIsoCode, isValid, filter);

            var totalCount = await query.LongCountAsync(GetCancellationToken(cancellationToken));

            return totalCount;
        }

        public async Task<List<Address>> GetListAsync(
            string sorting = null,
            int maxResultCount = 10,
            int skipCount = 0,
            string countryIsoCode = null,
            bool? isValid = null,
            string filter = null,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetListQuery(countryIsoCode, isValid, filter);

            return await query
                .OrderBy(sorting ?? "CreationTime DESC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual async Task<IQueryable<Address>> GetListQuery(
            string countryIsoCode = null,
            bool? isValid = null,
            string filter = null
        )
        {
            return (await GetQueryableAsync())
                .WhereIf(!countryIsoCode.IsNullOrWhiteSpace(), e => e.CountryIsoCode == countryIsoCode)
                .WhereIf(isValid.HasValue, e => e.IsValid == isValid)
                .WhereIf(!filter.IsNullOrWhiteSpace(),
                    e => false
                    || e.FullName.Contains(filter)
                    || e.StateProvince.Contains(filter)
                    || e.City.Contains(filter)
                    || e.Street.Contains(filter)
                );
        }
    }
}