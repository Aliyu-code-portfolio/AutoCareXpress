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
        Task<PickUpAddressDisplayDto> GetUserPickUpAddress(Guid userId, bool trackChanges);
        void UpdatePickUpAddress(PickUpAddressUpdateDto pickUpAddressUpdateDto);
        void DeletePickUpAddress(Guid id);
    }
}
