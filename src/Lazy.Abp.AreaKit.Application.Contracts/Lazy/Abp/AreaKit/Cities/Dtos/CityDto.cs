using System;
using Volo.Abp.Application.Dtos;
using Lazy.Abp.AreaKit.Countries.Dtos;
using Lazy.Abp.AreaKit.StateProvinces.Dtos;

namespace Lazy.Abp.AreaKit.Cities.Dtos
{
    [Serializable]
    public class CityDto : FullAuditedEntityDto<Guid>
    {
        public Guid CountryId { get; set; }

        public Guid StateProvinceId { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Abbreviation { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }

        public virtual CountryDto Country { get; set; }

        public virtual StateProvinceDto StateProvince { get; set; }
    }
}