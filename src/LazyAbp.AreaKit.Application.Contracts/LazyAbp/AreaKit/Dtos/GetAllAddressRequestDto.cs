using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.AreaKit.Dtos
{
    public class GetAllAddressRequestDto : PagedAndSortedResultRequestDto
    {
        public Guid? UserId { get; set; }

        public Guid? CountryId { get; set; }

        public Guid? StateProvinceId { get; set; }

        public Guid? CityId { get; set; }

        public bool? IsDefault { get; set; }

        public string Filter { get; set; }
    }
}
