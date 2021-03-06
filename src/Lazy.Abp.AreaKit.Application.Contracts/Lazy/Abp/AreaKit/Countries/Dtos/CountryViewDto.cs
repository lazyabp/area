using System;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Countries.Dtos
{
    [Serializable]
    public class CountryViewDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string CountryIsoCode { get; set; }

        public string CurrencyCode { get; set; }

        public string Flag { get; set; }

        public Continent Continent { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }
    }
}