using System;
using System.Collections.Generic;
using System.Text;

namespace LazyAbp.AreaKit.Dtos
{
    public class GetStateProvinceListRequestDto
    {
        public Guid? CountryId { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
