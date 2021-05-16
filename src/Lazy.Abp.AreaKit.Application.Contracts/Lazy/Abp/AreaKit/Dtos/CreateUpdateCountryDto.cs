using System;
using System.ComponentModel;
namespace Lazy.Abp.AreaKit.Dtos
{
    [Serializable]
    public class CreateUpdateCountryDto
    {
        //public Guid UserId { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string IsoCode2 { get; set; }

        public string IsoCode3 { get; set; }

        public string CurrencyCode { get; set; }

        public string Flag { get; set; }

        public Continent Continent { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }
    }
}