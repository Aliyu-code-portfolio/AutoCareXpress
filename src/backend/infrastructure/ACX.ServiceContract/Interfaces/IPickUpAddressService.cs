using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IPickUpAddressService
    {
        Task<PickUpAddressDisplayDto> GetUserPickUpAddress(string userId, bool trackChanges);
        Task<PickUpAddressDisplayDto> CreateUserPickUpAddress(PickUpAddressCreationDto pickUpAddressCreationDto);
        Task UpdatePickUpAddress(PickUpAddressUpdateDto pickUpAddressUpdateDto);
        Task DeletePickUpAddress(string id);
    }
}
