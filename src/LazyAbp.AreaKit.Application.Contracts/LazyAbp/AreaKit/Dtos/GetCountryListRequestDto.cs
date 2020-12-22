using System;
using System.Collections.Generic;
using System.Text;

namespace LazyAbp.AreaKit.Dtos
{
    public class GetCountryListRequestDto
    {
        public Continent? Continent { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
