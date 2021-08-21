using System;
using System.ComponentModel;
namespace Lazy.Abp.AreaKit.Addresses.Dtos
{
    [Serializable]
    public class AddressCreateUpdateDto
    {
        public virtual string CountryIsoCode { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string FullName { get; set; }

        public virtual string StateProvince { get; set; }

        public virtual string City { get; set; }

        public virtual string Street { get; set; }

        public virtual string Position { get; set; }

        public virtual bool IsValid { get; set; }
    }
}