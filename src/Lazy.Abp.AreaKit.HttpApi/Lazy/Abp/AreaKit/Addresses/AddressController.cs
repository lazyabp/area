using Lazy.Abp.AreaKit.Addresses.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaKit.Addresses
{
    [RemoteService(Name = AreaKitRemoteServiceConsts.RemoteServiceName)]
    [Area("areakit")]
    [ControllerName("Address")]
    [Route("api/areakit/addresses")]
    public class AddressController : AreaKitController, IAddressAppService
    {
        private readonly IAddressAppService _addressAppService;

        public AddressController(IAddressAppService addressAppService)
        {
            _addressAppService = addressAppService;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<AddressDto> GetAsync(Guid id)
        {
            return _addressAppService.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<AddressDto>> GetListAsync(AddressListRequestDto input)
        {
            return _addressAppService.GetListAsync(input);
        }

        [HttpPost]
        public Task<AddressDto> CreateAsync(AddressCreateUpdateDto input)
        {
            return _addressAppService.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<AddressDto> UpdateAsync(Guid id, AddressCreateUpdateDto input)
        {
            return _addressAppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        public Task DeleteAsync(Guid id)
        {
            return _addressAppService.DeleteAsync(id);
        }
    }
}
