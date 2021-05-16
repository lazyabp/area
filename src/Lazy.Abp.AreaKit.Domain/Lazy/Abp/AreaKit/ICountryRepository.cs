using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Lazy.Abp.AreaKit
{
    public interface ICountryRepository : IRepository<Country, Guid>
    {
        Task<long> GetCountAsync(
            //Guid? userId = null,
            Continent? continent = null,
            bool? isActive = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<Country>> GetListAsync(
            string sorting = null,
            int maxResultCount = 10,
            int skipCount = 0,
            //Guid? userId = null,
            Continent? continent = null,
            bool? isActive = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );

        Task<List<Country>> GetListAsync(
            string sorting = null,
            Continent? continent = null,
            bool? isActive = null,
            string filter = null,
            CancellationToken cancellationToken = default
        );
    }
}