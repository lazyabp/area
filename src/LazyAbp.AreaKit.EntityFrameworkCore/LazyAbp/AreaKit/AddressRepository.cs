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
    public class AddressRepository : EfCoreRepository<IAreaKitDbContext, Address, Guid>, IAddressRepository
    {
        public AddressRepository(IDbContextProvider<IAreaKitDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<long> GetCountAsync(
                Guid? userId = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                Guid? cityId = null,
                bool? isDefault = null,
                string filter = null,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(userId, countryId, stateProvinceId, cityId, isDefault, filter);

            var totalCount = await query.LongCountAsync(GetCancellationToken(cancellationToken));

            return totalCount;
        }

        public async Task<List<Address>> GetListAsync(
                string sorting = null,
                int maxResultCount = 10,
                int skipCount = 0,
                Guid? userId = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                Guid? cityId = null,
                bool? isDefault = null,
                string filter = null,
                bool includeDetails = true,
                CancellationToken cancellationToken = default
            )
        {
            var query = GetListQuery(userId, countryId, stateProvinceId, cityId, isDefault, filter);

            return await query.IncludeDetails(includeDetails).OrderBy(sorting ?? "CreationTime DESC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        protected virtual IQueryable<Address> GetListQuery(
                Guid? userId = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                Guid? cityId = null,
                bool? isDefault = null,
                string filter = null
            )
        {
            return DbSet.AsNoTracking()
                .WhereIf(userId.HasValue, e => false || e.UserId == userId)
                .WhereIf(countryId.HasValue, e => false || e.CountryId == countryId)
                .WhereIf(stateProvinceId.HasValue, e => false || e.StateProvinceId == stateProvinceId)
                .WhereIf(cityId.HasValue, e => false || e.CityId == cityId)
                .WhereIf(isDefault.HasValue, e => false || e.IsDefault == isDefault)
                .WhereIf(!string.IsNullOrEmpty(filter),
                    e => false
                    || e.FullName.Contains(filter)
                    || e.Address1.Contains(filter)
                    || e.Address2.Contains(filter)
                    || e.PostCode.Contains(filter)
                    || e.Email.Contains(filter)
                    || e.PhoneNumber.Contains(filter)
                    || e.Tag.Contains(filter)
                );
        }
    }
}