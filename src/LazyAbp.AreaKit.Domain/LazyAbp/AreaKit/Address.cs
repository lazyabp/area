using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace LazyAbp.AreaKit
{
    public class Address : FullAuditedAggregateRoot<Guid>
    {
        public virtual Guid? TenantId { get; set; }

        public virtual Guid UserId { get; private set; }

        public virtual string FirstName { get; private set; }

        public virtual string LastName { get; private set; }

        public virtual string FullName { get; private set; }

        public virtual string Company { get; private set; }

        public virtual Guid CountryId { get; private set; }

        public virtual Guid StateProvinceId { get; private set; }

        public virtual Guid CityId { get; private set; }

        /// <summary>
        /// 郡县
        /// </summary>
        public virtual string County { get; private set; }

        public virtual string Address1 { get; private set; }

        public virtual string Address2 { get; private set; }

        public virtual string PostCode { get; private set; }

        public virtual string Email { get; private set; }

        public virtual string PhoneNumber { get; private set; }

        public virtual string FaxNumber { get; private set; }

        [MaxLength(AddressConsts.MaxTagLength)]
        public virtual string Tag { get; private set; }

        public virtual bool IsDefault { get; private set; }

        public virtual int DisplayOrder { get; private set; }

        public virtual Country Country { get; set; }

        public virtual StateProvince StateProvince { get; set; }

        public virtual City City { get; set; }

        protected Address()
        {
        }

        public Address(
            Guid id,
            Guid userId,
            string firstName, 
            string lastName, 
            string fullName, 
            string company, 
            Guid countryId, 
            Guid stateProvinceId, 
            Guid cityId, 
            string county, 
            string address1, 
            string address2, 
            string postCode, 
            string email, 
            string phoneNumber, 
            string faxNumber, 
            string tag, 
            bool isDefault, 
            int displayOrder
        ) : base(id)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Company = company;
            CountryId = countryId;
            StateProvinceId = stateProvinceId;
            CityId = cityId;
            County = county;
            Address1 = address1;
            Address2 = address2;
            PostCode = postCode;
            Email = email;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            Tag = tag;
            IsDefault = isDefault;
            DisplayOrder = displayOrder;
        }

        public void Update(
            string firstName,
            string lastName,
            string fullName,
            string company,
            Guid countryId,
            Guid stateProvinceId,
            Guid cityId,
            string county,
            string address1,
            string address2,
            string postCode,
            string email,
            string phoneNumber,
            string faxNumber,
            string tag,
            bool isDefault,
            int displayOrder
            )
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            Company = company;
            CountryId = countryId;
            StateProvinceId = stateProvinceId;
            CityId = cityId;
            County = county;
            Address1 = address1;
            Address2 = address2;
            PostCode = postCode;
            Email = email;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            Tag = tag;
            IsDefault = isDefault;
            DisplayOrder = displayOrder;
        }
    }
}
