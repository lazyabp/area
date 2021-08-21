using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy.Abp.AreaKit.Cities.Dtos
{
    public class CityListRequestDto
    {
        public Guid? StateProvinceId { get; set; }

        public string Filter { get; set; }

        //public bool IncludeDetails { get; set; }
    }
}
