using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Dtos
{
    public class GetAllStateProvinceRequestDto : PagedAndSortedResultRequestDto
    {
        //public Guid? UserId { get; set; }

        public Guid? CountryId { get; set; }

        public bool? IsActive { get; set; }

        public string Filter { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
