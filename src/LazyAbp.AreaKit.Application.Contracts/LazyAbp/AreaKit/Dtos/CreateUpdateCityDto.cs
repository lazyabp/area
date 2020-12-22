using System;
using System.ComponentModel;
namespace LazyAbp.AreaKit.Dtos
{
    [Serializable]
    public class CreateUpdateCityDto
    {
        //public Guid UserId { get; set; }

        //public Guid? CountryId { get; set; }

        public Guid StateProvinceId { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Abbreviation { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }
    }
}