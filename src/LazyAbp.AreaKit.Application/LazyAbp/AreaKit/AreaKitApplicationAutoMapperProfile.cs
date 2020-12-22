using LazyAbp.AreaKit;
using LazyAbp.AreaKit.Dtos;
using AutoMapper;

namespace LazyAbp.AreaKit
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
            CreateMap<CreateUpdateCountryDto, Country>(MemberList.Source);

            CreateMap<StateProvince, StateProvinceDto>();
            CreateMap<StateProvince, StateProvinceViewDto>();
            CreateMap<CreateUpdateStateProvinceDto, StateProvince>(MemberList.Source);

            CreateMap<City, CityDto>();
            CreateMap<City, CityViewDto>();
            CreateMap<CreateUpdateCityDto, City>(MemberList.Source);

            CreateMap<Address, AddressDto>();
            CreateMap<CreateUpdateAddressDto, Address>(MemberList.Source);
        }
    }
}
