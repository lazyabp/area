using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lazy.Abp.AreaKit
{
    public class City : FullAuditedAggregateRoot<Guid>
    {
        //public virtual Guid UserId { get; private set; }

        public virtual Guid CountryId { get; private set; }

        public virtual Guid StateProvinceId { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string DisplayName { get; private set; }

        /// <summary>
        /// 缩写
        /// </summary>
        [MaxLength(CityConsts.MaxAbbreviationLength)]
        public virtual string Abbreviation { get; private set; }

        public virtual bool IsActive { get; set; }

        public virtual int DisplayOrder { get; private set; }

        //[ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        //[ForeignKey("StateProvinceId")]
        public virtual StateProvince StateProvince { get; set; }

        protected City()
        {
        }

        public City(
            Guid id,
            //Guid userId,
            Guid countryId, 
            Guid stateProvinceId, 
            string name, 
            string displayName, 
            string abbreviation, 
            bool isActive, 
            int displayOrder
        ) : base(id)
        {
            //UserId = userId;
            CountryId = countryId;
            StateProvinceId = stateProvinceId;
            Name = name;
            DisplayName = displayName;
            Abbreviation = abbreviation;
            IsActive = isActive;
            DisplayOrder = displayOrder;
        }

        public void Update(
            Guid countryId,
            Guid stateProvinceId,
            string name,
            string displayName,
            string abbreviation,
            bool isActive,
            int displayOrder
        )
        {
            CountryId = countryId;
            StateProvinceId = stateProvinceId;
            Name = name;
            DisplayName = displayName;
            Abbreviation = abbreviation;
            IsActive = isActive;
            DisplayOrder = displayOrder;
        }
    }
}
