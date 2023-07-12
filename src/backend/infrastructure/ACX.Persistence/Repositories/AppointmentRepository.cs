using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
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

        public async Task<PagedList<Appointment>> GetAllAppointmentAsync(AppointmentRequestParameters requestParameters, bool trackChanges)
        {
            var appointments = await FindAll(trackChanges).Skip((requestParameters.PageNumber-1)*requestParameters.PageSize)
                .Take(requestParameters.PageSize).ToListAsync();
            var count = await FindAll(false).CountAsync();

            return new PagedList<Appointment>(appointments,count,requestParameters.PageNumber,requestParameters.PageSize);
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id, bool trackChanges)
        {
            var appointment = await FindByCondition(a => a.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return appointment;
        }

        public async Task<PagedList<Appointment>> GetAppointmentsByServiceProviderIdAsync(string serviceProviderId, AppointmentRequestParameters requestParameters, bool trackChanges)
        {
            var appointments = await FindByCondition(a => a.ServiceProviderId.Equals(serviceProviderId), trackChanges).Skip((requestParameters.PageNumber - 1) * requestParameters.PageSize)
                .Take(requestParameters.PageSize).ToListAsync();
            var count = await FindByCondition(a => a.ServiceProviderId.Equals(serviceProviderId), trackChanges).CountAsync();

            return new PagedList<Appointment>(appointments,count,requestParameters.PageNumber,requestParameters.PageSize);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByStatusAsync(bool status, bool trackChanges)
        {
            var appointment = await FindByCondition(a => a.Status == status, trackChanges).ToListAsync();
            return appointment;
        }
        
        public async Task<PagedList<Appointment>> GetAppointmentsByUserIdAsync(string userId, AppointmentRequestParameters requestParameters, bool trackChanges)
        {
            var appointments = await FindByCondition(a => a.UserId.Equals(userId), trackChanges).Skip((requestParameters.PageNumber - 1) * requestParameters.PageSize)
                .Take(requestParameters.PageSize).ToListAsync();
            var count = await FindByCondition(a => a.UserId.Equals(userId), trackChanges).CountAsync();

            return new PagedList<Appointment>(appointments, count, requestParameters.PageNumber, requestParameters.PageSize);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            Update(appointment);
        }
    }
}
