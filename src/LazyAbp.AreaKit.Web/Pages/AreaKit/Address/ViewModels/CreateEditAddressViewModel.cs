using LazyAbp.AreaKit.Dtos;
using System;

using System.ComponentModel.DataAnnotations;

namespace LazyAbp.AreaKit.Web.Pages.AreaKit.Address.ViewModels
{
    public class CreateEditAddressViewModel
    {
        [Display(AutoGenerateField = false)]
        public Guid UserId { get; set; }

        [Display(Name = "AddressFirstName")]
        public string FirstName { get; set; }

        [Display(Name = "AddressLastName")]
        public string LastName { get; set; }

        [Display(Name = "AddressFullName")]
        public string FullName { get; set; }

        [Display(Name = "AddressCompany")]
        public string Company { get; set; }

        [Display(Name = "AddressCountryId")]
        public Guid CountryId { get; set; }

        [Display(Name = "AddressStateProvinceId")]
        public Guid StateProvinceId { get; set; }

        [Display(Name = "AddressCityId")]
        public Guid CityId { get; set; }

        [Display(Name = "AddressCounty")]
        public string County { get; set; }

        [Display(Name = "AddressAddress1")]
        public string Address1 { get; set; }

        [Display(Name = "AddressAddress2")]
        public string Address2 { get; set; }

        [Display(Name = "AddressPostCode")]
        public string PostCode { get; set; }

        [Display(Name = "AddressEmail")]
        public string Email { get; set; }

        [Display(Name = "AddressPhoneNumber")]
        public string PhoneNumber { get; set; }

        [Display(Name = "AddressFaxNumber")]
        public string FaxNumber { get; set; }

        [Display(Name = "AddressTag")]
        public string Tag { get; set; }

        [Display(Name = "AddressIsDefault")]
        public bool IsDefault { get; set; }

        [Display(Name = "AddressDisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}