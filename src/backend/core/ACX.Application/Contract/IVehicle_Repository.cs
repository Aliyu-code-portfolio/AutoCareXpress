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
        Task<IEnumerable<Vehicle>> GetAllUserVehicle(string userId,bool trackChanges);
        void CreateVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
    }
}
