using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IPickUpAddress_Repository
    {
        Task<IEnumerable<PickUpAddress>> GetAllPickUpAddress(bool trackChanges);
        Task<PickUpAddress> GetPickUpAddressByUserId(string userId, bool trackChanges);
        void CreatePickUpAddress(PickUpAddress pickUpAddress);
        void UpdatePickUpAddress(PickUpAddress pickUpAddress);
        void DeletePickUpAddress(PickUpAddress pickUpAddress);
    }
}
