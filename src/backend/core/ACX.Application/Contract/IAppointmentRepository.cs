using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetAllAppointmentAsync(bool trackChanges);
        Task<Appointment> GetAppointmentByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByStatusAsync(bool status, bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByUserIdAsync(Guid userId, bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByServiceProviderIdAsync(Guid serviceProviderId, bool trackChanges);
        void CreateAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
    }
}
