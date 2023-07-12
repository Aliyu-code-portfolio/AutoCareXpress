using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.ServiceContract.Common;
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
        Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllUserAppointments(string userId, AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllServiceProviderAppointments(string providerId, AppointmentRequestParameters requestParameters, bool trackChanges);
        Task<AppointmentDisplayDto> GetAppointmentById(int id);
        Task<AppointmentDisplayDto> CreateAppointment(AppointmentCreationDto appointmentCreationDto);
        Task UpdateStatus(int id,bool flag);
        Task Rate(int id,int rating);
        Task DeleteAppointment(int id);

    }
}
