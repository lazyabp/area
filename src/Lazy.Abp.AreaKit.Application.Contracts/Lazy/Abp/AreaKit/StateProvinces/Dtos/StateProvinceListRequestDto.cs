using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy.Abp.AreaKit.StateProvinces.Dtos
{
    public class StateProvinceListRequestDto
    {
        public Guid? CountryId { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
