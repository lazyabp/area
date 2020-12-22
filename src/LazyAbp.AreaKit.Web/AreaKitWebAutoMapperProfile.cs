using AutoMapper;
using LazyAbp.AreaKit.Dtos;
using LazyAbp.AreaKit.Web.Pages.AreaKit.Address.ViewModels;

namespace LazyAbp.AreaKit.Web
{
    public class AreaKitWebAutoMapperProfile : Profile
    {
        public AreaKitWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<AddressDto, CreateEditAddressViewModel>()
                .ForMember(m => m.UserId, op => op.Ignore());
            CreateMap<CreateEditAddressViewModel, CreateUpdateAddressDto>();
        }
    }
}