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
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDisplayDto>> GetAllVehicles(bool trackChanges);
        Task<IEnumerable<VehicleDisplayDto>> GetAllUserVehicles(Guid userId, bool trackChanges);
        Task<VehicleDisplayDto> GetVehicleById(int id);
        Task<VehicleDisplayDto> CreateVehicle(VehicleCreationDto vehicleCreationDto);
        void UpdateVehicle(VehicleUpdateDto vehicleUpdateDto);
        void DeleteVehicle(int id);
    }
}
