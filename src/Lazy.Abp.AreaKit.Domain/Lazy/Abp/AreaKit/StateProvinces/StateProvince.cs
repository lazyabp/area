using Lazy.Abp.AreaKit.Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lazy.Abp.AreaKit.StateProvinces
{
    public class StateProvince : FullAuditedAggregateRoot<Guid>
    {
        //public virtual Guid UserId { get; private set; }

        public virtual Guid CountryId { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string DisplayName { get; private set; }

        /// <summary>
        /// 缩写
        /// </summary>
        [MaxLength(StateProvinceConsts.MaxAbbreviationLength)]
        public virtual string Abbreviation { get; private set; }

        public virtual bool IsActive { get; set; }

        public virtual int DisplayOrder { get; private set; }

        //[ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        protected StateProvince()
        {
        }

        public StateProvince(
            Guid id,
            //Guid userId,
            Guid countryId, 
            string name, 
            string displayName, 
            string abbreviation, 
            bool isActive, 
            int displayOrder
        ) : base(id)
        {
            //UserId = userId;
            CountryId = countryId;
            Name = name;
            DisplayName = displayName;
            Abbreviation = abbreviation;
            IsActive = isActive;
            DisplayOrder = displayOrder;
        }
    }
}
