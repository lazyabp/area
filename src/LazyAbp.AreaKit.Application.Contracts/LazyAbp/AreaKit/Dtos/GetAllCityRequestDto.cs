using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.AreaKit.Dtos
{
    public class GetAllCityRequestDto : PagedAndSortedResultRequestDto
    {
        //public Guid? UserId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid? StateProvinceId { get; set; }

        public bool? IsActive { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
