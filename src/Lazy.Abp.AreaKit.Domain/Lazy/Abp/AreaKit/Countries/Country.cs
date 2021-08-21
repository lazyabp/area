using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lazy.Abp.AreaKit.Countries
{
    public class Country : FullAuditedAggregateRoot<Guid>
    {
        //public virtual Guid UserId { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string DisplayName { get; private set; }

        [MaxLength(CountryConsts.MaxIsoCode2Length)]
        public virtual string CountryIsoCode { get; private set; }

        [MaxLength(CountryConsts.MaxCurrencyCodeLength)]
        public virtual string CurrencyCode { get; private set; }

        [MaxLength(CountryConsts.MaxFlagLength)]
        public virtual string Flag { get; private set; }

        public virtual Continent Continent { get; private set; }

        public virtual bool IsActive { get; set; }

        public virtual int DisplayOrder { get; private set; }

        protected Country()
        {
        }

        public Country(
            Guid id,
            //Guid userId,
            string name, 
            string displayName,
            string countryIsoCode,
            string currencyCode, 
            string flag, 
            Continent continent, 
            bool isActive, 
            int displayOrder
        ) : base(id)
        {
            //UserId = userId;
            Name = name;
            DisplayName = displayName;
            CountryIsoCode = countryIsoCode;
            CurrencyCode = currencyCode;
            Flag = flag;
            Continent = continent;
            IsActive = isActive;
            DisplayOrder = displayOrder;
        }
    }
}
