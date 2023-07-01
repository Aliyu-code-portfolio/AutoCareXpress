using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Repositories
{
    internal sealed class VehicleRepsoitory : RepositoryBase<Vehicle>, IVehicle_Repository
    {
        public VehicleRepsoitory(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            Create(vehicle);
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            Delete(vehicle);
        }

        //please crosscheck this also
        public async Task<IEnumerable<Vehicle>> GetAllUserVehicle(Guid userId, bool trackChanges)
        {
            var vehicles = await FindByCondition(v => v.UserId.Equals(userId), trackChanges).ToListAsync();
            return vehicles;
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehicle(bool trackChanges)
        {
            var vehicles = await FindAll(trackChanges).ToListAsync();
            return vehicles;
        }

        public async Task<Vehicle?> GetVehicleById(int id, bool trackChanges)
        {
            var vehicle = await FindByCondition(v => v.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return vehicle;
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            Update(vehicle);
        }
    }
}
