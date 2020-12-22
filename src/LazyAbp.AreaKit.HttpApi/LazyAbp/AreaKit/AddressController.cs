using LazyAbp.AreaKit.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace LazyAbp.AreaKit
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
        public Task<PagedResultDto<AddressDto>> GetListAsync(GetAllAddressRequestDto input)
        {
            return _addressAppService.GetListAsync(input);
        }

        [HttpPost]
        public Task<AddressDto> CreateAsync(CreateUpdateAddressDto input)
        {
            return _addressAppService.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<AddressDto> UpdateAsync(Guid id, CreateUpdateAddressDto input)
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
