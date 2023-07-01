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
        Task<IEnumerable<Appointment>> GetAllAsync(bool trackChanges);
        Task<Appointment> GetAppointmentByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByStatusAsync(bool status, bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByUserIdAsync(bool trackChanges);
        Task<IEnumerable<Appointment>> GetAppointmentsByServiceProviderIdAsync(bool trackChanges);
        void CreateAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
    }
}
