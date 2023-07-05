using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IAppointmentService
    {
        Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllAppointments(AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllUserAppointments(Guid userId, AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllServiceProviderAppointments(Guid providerId, AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<AppointmentDisplayDto> GetAppointmentById(int id);
        Task<AppointmentDisplayDto> CreateAppointment(AppointmentCreationDto appointmentCreationDto);
        Task DeleteAppointment(int id);

    }
}
