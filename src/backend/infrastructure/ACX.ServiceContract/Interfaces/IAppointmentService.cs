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
    public interface IAppointmentService
    {
        Task<IEnumerable<AppointmentDisplayDto>> GetAllAppointments(bool trackChanges);
        Task<IEnumerable<AppointmentDisplayDto>> GetAllUserAppointments(Guid userId, bool trackChanges);
        Task<IEnumerable<AppointmentDisplayDto>> GetAllServiceProviderAppointments(Guid providerId, bool trackChanges);
        Task<AppointmentDisplayDto> GetAppointmentById(int id);
        Task<AppointmentDisplayDto> CreateAppointment(AppointmentCreationDto appointmentCreationDto);
        void DeleteAppointment(int id);

    }
}
