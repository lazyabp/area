using System;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Dtos
{
    [Serializable]
    public class StateProvinceDto : FullAuditedEntityDto<Guid>
    {
        public Guid CountryId { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Abbreviation { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }

        public virtual CountryDto Country { get; set; }
    }
}