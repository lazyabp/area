using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy.Abp.AreaKit.Dtos
{
    public class GetCityListRequestDto
    {
        public Guid? StateProvinceId { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
