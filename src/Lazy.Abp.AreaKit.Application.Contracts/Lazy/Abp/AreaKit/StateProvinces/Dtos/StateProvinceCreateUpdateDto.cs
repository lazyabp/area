using System;
using System.ComponentModel;

namespace Lazy.Abp.AreaKit.StateProvinces.Dtos
{
    [Serializable]
    public class StateProvinceCreateUpdateDto
    {
        //public Guid UserId { get; set; }

        public string CountryIsoCode { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Abbreviation { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }
    }
}