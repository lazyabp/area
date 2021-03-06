using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Lazy.Abp.AreaKit.Addresses
{
    public interface IAddressRepository : IRepository<Address, Guid>
    {
        Task<long> GetCountAsync(
            string countryIsoCode = null,
            bool? isValid = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<Address>> GetListAsync(
            string sorting = null,
            int maxResultCount = 10,
            int skipCount = 0,
            string countryIsoCode = null,
            bool? isValid = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );
    }
}