using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LazyAbp.AreaKit;
using LazyAbp.AreaKit.Dtos;
using LazyAbp.AreaKit.Web.Pages.AreaKit.Address.ViewModels;
using Volo.Abp.Users;

namespace LazyAbp.AreaKit.Web.Pages.AreaKit.Address
{
    public class CreateModalModel : AreaKitPageModel
    {
        [BindProperty]
        public CreateEditAddressViewModel ViewModel { get; set; }

        private readonly IAddressAppService _service;

        public CreateModalModel(IAddressAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditAddressViewModel, CreateUpdateAddressDto>(ViewModel);
            dto.UserId = CurrentUser.GetId();

            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}