using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Addresses.Dtos
{
    public class AddressListRequestDto : PagedAndSortedResultRequestDto
    {
        public bool? IsValid { get; set; }

        public string Filter { get; set; }
    }
}
