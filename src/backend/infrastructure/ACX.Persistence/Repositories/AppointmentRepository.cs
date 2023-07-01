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
    internal sealed class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
        public void CreateAppointment(Appointment appointment)
        {
            Create(appointment);
        }

        public void DeleteAppointment(Appointment appointment)
        {
            Delete(appointment);
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointmentAsync(bool trackChanges)
        {
            var appointments = await FindAll(trackChanges).ToListAsync();
            return appointments;
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id, bool trackChanges)
        {
            var appointment = await FindByCondition(a => a.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return appointment;
        }

        //please crosscheck here. I dont know how to implement this part you included. I think there should be a serviceProviderId before, trackchanges.
        public async Task<IEnumerable<Appointment>> GetAppointmentsByServiceProviderIdAsync(Guid serviceProviderId, bool trackChanges)
        {
            var appointment = await FindByCondition(a => a.ServiceProviderId.Equals(serviceProviderId), trackChanges).ToListAsync();
            return appointment;
        }

        //also glance at this
        public async Task<IEnumerable<Appointment>> GetAppointmentsByStatusAsync(bool status, bool trackChanges)
        {
            var appointment = await FindByCondition(a => a.Status == status, trackChanges).ToListAsync();
            return appointment;
        }

        //same thing here. I think there should be a parameter of UserId before trackChanges
        public async Task<IEnumerable<Appointment>> GetAppointmentsByUserIdAsync(Guid userId, bool trackChanges)
        {
            var appointment = await FindByCondition(a => a.UserId.Equals(userId), trackChanges).ToListAsync();
            return appointment;
        }
    }
}
