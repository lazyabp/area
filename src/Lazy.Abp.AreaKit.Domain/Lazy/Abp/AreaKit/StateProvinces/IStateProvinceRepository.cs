using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Lazy.Abp.AreaKit.StateProvinces
{
    public interface IStateProvinceRepository : IRepository<StateProvince, Guid>
    {
        Task<long> GetCountAsync(
            //Guid? userId = null,
            string countryIsoCode = null,
            bool? isActive = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<StateProvince>> GetListAsync(
            string sorting = null,
            int maxResultCount = 10,
            int skipCount = 0,
            //Guid? userId = null,
            string countryIsoCode = null,
            bool? isActive = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<StateProvince>> GetListAsync(
            string sorting = null,
            string countryIsoCode = null,
            bool? isActive = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );
    }
}