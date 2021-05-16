using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Dtos
{
    public class GetAllAddressRequestDto : PagedAndSortedResultRequestDto
    {
        public Guid? CountryId { get; set; }

        public bool? IsValid { get; set; }

        public string Filter { get; set; }
    }
}
