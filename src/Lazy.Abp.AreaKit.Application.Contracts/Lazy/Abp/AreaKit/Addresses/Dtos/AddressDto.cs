using Lazy.Abp.AreaKit.Countries.Dtos;
using System;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Addresses.Dtos
{
    [Serializable]
    public class AddressDto : FullAuditedEntityDto<Guid>
    {
        public virtual Guid CountryId { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string FullName { get; set; }

        public virtual string State { get; set; }

        public virtual string City { get; set; }

        public virtual string Street { get; set; }

        public virtual string Position { get; set; }

        public virtual bool IsValid { get; set; }

        public virtual CountryDto Country { get; set; }
    }
}