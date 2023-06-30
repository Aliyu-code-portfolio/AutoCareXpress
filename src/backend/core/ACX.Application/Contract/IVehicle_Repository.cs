using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IVehicle_Repository
    {
        Task<IEnumerable<Vehicle>> GetAllVehicle(bool trackChanges);
        Task<Vehicle?> GetVehicleById(int id, bool trackChanges);
        Task<IEnumerable<Vehicle>> GetAllUserVehicle(Guid userId,bool trackChanges);
        void AddVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
    }
}
