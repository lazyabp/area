using Lazy.Abp.AreaKit.Countries.Dtos;
using System;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.StateProvinces.Dtos
{
    [Serializable]
    public class StateProvinceViewDto : EntityDto<Guid>
    {
        public string CountryIsoCode { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Abbreviation { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }

        //public virtual CountryViewDto Country { get; set; }
    }
}