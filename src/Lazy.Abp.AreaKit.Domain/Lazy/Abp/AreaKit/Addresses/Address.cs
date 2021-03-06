using Lazy.Abp.AreaKit.Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Lazy.Abp.AreaKit.Addresses
{
    public class Address : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; set; }

        public virtual string CountryIsoCode { get; private set; }

        public virtual string FirstName { get; private set; }

        public virtual string LastName { get; private set; }

        public virtual string FullName { get; private set; }

        public virtual string StateProvince { get; private set; }

        public virtual string City { get; private set; }

        public virtual string Street { get; private set; }

        public virtual string Position { get; private set; }

        public virtual bool IsValid { get; private set; }

        //[ForeignKey("CountryId")]
        //public virtual Country Country { get; set; }

        protected Address()
        {
        }

        public Address(
            Guid id,
            Guid? tenantId,
            string countryIsoCode,
            string firstName, 
            string lastName, 
            string fullName,
            string stateProvince,
            string city, 
            string street, 
            string position, 
            bool isValid
        ) : base(id)
        {
            TenantId = tenantId;
            CountryIsoCode = countryIsoCode;
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            StateProvince = stateProvince;
            City = city;
            Street = street;
            Position = position;
            IsValid = isValid;
        }

        public void Update(
            string firstName,
            string lastName,
            string fullName,
            string stateProvince,
            string city,
            string street,
            string position,
            bool isValid
        )
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = fullName;
            StateProvince = stateProvince;
            City = city;
            Street = street;
            Position = position;
            IsValid = isValid;
        }

        public void SetAsValid(bool isValid = true)
        {
            IsValid = isValid;
        }
    }
}
