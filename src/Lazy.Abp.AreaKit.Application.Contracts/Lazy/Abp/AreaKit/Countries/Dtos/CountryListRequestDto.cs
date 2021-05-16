using System;
using System.Collections.Generic;
using System.Text;

namespace Lazy.Abp.AreaKit.Countries.Dtos
{
    public class CountryListRequestDto
    {
        public Continent? Continent { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
