using System;
using System.ComponentModel;
namespace LazyAbp.AreaKit.Dtos
{
    [Serializable]
    public class CreateUpdateAddressDto
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Company { get; set; }

        //public Guid? CountryId { get; set; }

        //public Guid? StateProvinceId { get; set; }

        public Guid CityId { get; set; }

        public string County { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string PostCode { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FaxNumber { get; set; }

        public string Tag { get; set; }

        public bool IsDefault { get; set; }

        public int DisplayOrder { get; set; }
    }
}