using AutoMapper;
using Lazy.Abp.AreaKit.Countries;
using Lazy.Abp.AreaKit.StateProvinces;
using Lazy.Abp.AreaKit.Cities;
using Lazy.Abp.AreaKit.Addresses;
using Lazy.Abp.AreaKit.Countries.Dtos;
using Lazy.Abp.AreaKit.StateProvinces.Dtos;
using Lazy.Abp.AreaKit.Cities.Dtos;
using Lazy.Abp.AreaKit.Addresses.Dtos;

namespace Lazy.Abp.AreaKit
{
    public class AreaKitApplicationAutoMapperProfile : Profile
    {
        public AreaKitApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Country, CountryDto>();
            CreateMap<Country, CountryViewDto>();
            CreateMap<CountryCreateUpdateDto, Country>(MemberList.Source);

            CreateMap<StateProvince, StateProvinceDto>();
            CreateMap<StateProvince, StateProvinceViewDto>();
            CreateMap<StateProvinceCreateUpdateDto, StateProvince>(MemberList.Source);

            CreateMap<City, CityDto>();
            CreateMap<City, CityViewDto>();
            CreateMap<CityCreateUpdateDto, City>(MemberList.Source);

            CreateMap<Address, AddressDto>();
            CreateMap<AddressCreateUpdateDto, Address>(MemberList.Source);
        }
    }
}
