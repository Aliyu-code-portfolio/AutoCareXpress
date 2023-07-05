using ACX.Domain.Model;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IAppointmentRepository
    {
        Task<PagedList<Appointment>> GetAllAppointmentAsync(AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<Appointment> GetAppointmentByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByStatusAsync(bool status, bool trackChanges);
        Task<PagedList<Appointment>> GetAppointmentsByUserIdAsync(Guid userId, AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<PagedList<Appointment>> GetAppointmentsByServiceProviderIdAsync(Guid serviceProviderId, AppointmentRequestParameters requestParameters, bool trackChanges);
        void CreateAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
    }
}
