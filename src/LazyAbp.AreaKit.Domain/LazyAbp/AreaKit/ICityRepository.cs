using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace LazyAbp.AreaKit
{
    public interface ICityRepository : IRepository<City, Guid>
    {
        Task<long> GetCountAsync(
                //Guid? userId = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                bool? isActive = null,
                string filter = null,
                CancellationToken cancellationToken = default
            );

        Task<List<City>> GetListAsync(
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
            );

        Task<List<City>> GetListAsync(
                string sorting = null,
                Guid? countryId = null,
                Guid? stateProvinceId = null,
                bool? isActive = null,
                string filter = null,
                bool includeDetails = true,
                CancellationToken cancellationToken = default
            );
    }
}