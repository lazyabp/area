using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LazyAbp.AreaKit;
using LazyAbp.AreaKit.Dtos;
using LazyAbp.AreaKit.Web.Pages.AreaKit.Address.ViewModels;

namespace LazyAbp.AreaKit.Web.Pages.AreaKit.Address
{
    public class EditModalModel : AreaKitPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditAddressViewModel ViewModel { get; set; }

        private readonly IAddressAppService _service;

        public EditModalModel(IAddressAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<AddressDto, CreateEditAddressViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditAddressViewModel, CreateUpdateAddressDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}