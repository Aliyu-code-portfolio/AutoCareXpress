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
        Task<IEnumerable<PickUpAddress>> GetAllPickUpPickUpAddress(bool trackChanges);
        Task<PickUpAddress> GetPickUpAddressById(int id, bool trackChanges);
        void AddPickUpAddress(PickUpAddress pickupaddress);
        Task UpdatePickUpAddress(PickUpAddress pickupaddress);
        void DeletePickUpAddress(PickUpAddress pickupAddress);
    }
}
