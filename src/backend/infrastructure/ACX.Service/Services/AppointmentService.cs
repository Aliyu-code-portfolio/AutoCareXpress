using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Services
{
    internal sealed class AppointmentService : IAppointmentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public AppointmentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<AppointmentDisplayDto> CreateAppointment(AppointmentCreationDto appointmentCreationDto)
        {
            var appointment = _mapper.Map<Appointment>(appointmentCreationDto);
            _repositoryManager.AppointmentRepository.CreateAppointment(appointment);
            await _repositoryManager.SaveChangesAsync();
            var appointmentDto = _mapper.Map<AppointmentDisplayDto>(appointment);
            return appointmentDto;
        }

        public async Task DeleteAppointment(int id)
        {
            var appointment = await _repositoryManager.AppointmentRepository.GetAppointmentByIdAsync(id, false)
                ?? throw new AppointmentNotFoundException(id);
            _repositoryManager.AppointmentRepository.DeleteAppointment(appointment);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllAppointments(AppointmentRequestParameters requestParameters, bool trackChanges)
        {
            var appointments = await _repositoryManager.AppointmentRepository.GetAllAppointmentAsync(requestParameters, false);
            var appointmentDto = _mapper.Map<IEnumerable<AppointmentDisplayDto>>(appointments);
            foreach(var appointment in appointmentDto)
            {
                var serviceProvider = await _repositoryManager.ServiceProviderRepository
                    .GetServiceProviderByIdAsync(appointment.ServiceProviderId,false)
                    ?? throw new ServiceProviderNotFoundException(appointment.ServiceProviderId);

                var serviceType = await _repositoryManager.Ref_Service_Type_Repository
                    .GetServiceTypeById(appointment.Ref_Service_Type_Id)
                    ?? throw new Ref_Service_Type_NotFoundException(appointment.Ref_Service_Type_Id);

                var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
                var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
                appointment.ServiceProviderDisplayDto=serviceProviderDto;
                appointment.Ref_Service_Type_Display_Dto = serviceTypeDto;
            }
            return (appointmentDto,appointments.MetaData);
        }

        public async Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllServiceProviderAppointments(Guid providerId, AppointmentRequestParameters requestParameters,  bool trackChanges)
        {
            var appointments = await _repositoryManager.AppointmentRepository.GetAppointmentsByServiceProviderIdAsync(providerId,requestParameters, false);
            var appointmentDto = _mapper.Map<IEnumerable<AppointmentDisplayDto>>(appointments);
            foreach (var appointment in appointmentDto)
            {
                var serviceProvider = await _repositoryManager.ServiceProviderRepository
                    .GetServiceProviderByIdAsync(appointment.ServiceProviderId, false)
                    ?? throw new ServiceProviderNotFoundException(appointment.ServiceProviderId);

                var serviceType = await _repositoryManager.Ref_Service_Type_Repository
                    .GetServiceTypeById(appointment.Ref_Service_Type_Id)
                    ?? throw new Ref_Service_Type_NotFoundException(appointment.Ref_Service_Type_Id);

                var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
                var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
                appointment.ServiceProviderDisplayDto = serviceProviderDto;
                appointment.Ref_Service_Type_Display_Dto = serviceTypeDto;
            }
            return (appointmentDto,appointments.MetaData);
        }

        public async Task<(IEnumerable<AppointmentDisplayDto> Appointments, MetaData MetaData)> GetAllUserAppointments(Guid userId, AppointmentRequestParameters requestParameters, bool trackChanges)
        {
            var appointments = await _repositoryManager.AppointmentRepository.GetAppointmentsByUserIdAsync(userId,requestParameters, false);
            var appointmentDto = _mapper.Map<IEnumerable<AppointmentDisplayDto>>(appointments);
            foreach (var appointment in appointmentDto)
            {
                var serviceProvider = await _repositoryManager.ServiceProviderRepository
                    .GetServiceProviderByIdAsync(appointment.ServiceProviderId, false)
                    ?? throw new ServiceProviderNotFoundException(appointment.ServiceProviderId);

                var serviceType = await _repositoryManager.Ref_Service_Type_Repository
                    .GetServiceTypeById(appointment.Ref_Service_Type_Id)
                    ?? throw new Ref_Service_Type_NotFoundException(appointment.Ref_Service_Type_Id);

                var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
                var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
                appointment.ServiceProviderDisplayDto = serviceProviderDto;
                appointment.Ref_Service_Type_Display_Dto = serviceTypeDto;
            }
            return (appointmentDto,appointments.MetaData);
        }

        public async Task<AppointmentDisplayDto> GetAppointmentById(int id)
        {
            var appointment = await _repositoryManager.AppointmentRepository.GetAppointmentByIdAsync(id, false)
                ?? throw new AppointmentNotFoundException(id);
            var appointmentDto = _mapper.Map<AppointmentDisplayDto>(appointment);
            
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetServiceProviderByIdAsync(appointmentDto.ServiceProviderId, false)
                ?? throw new ServiceProviderNotFoundException(appointmentDto.ServiceProviderId);

            var serviceType = await _repositoryManager.Ref_Service_Type_Repository
                .GetServiceTypeById(appointmentDto.Ref_Service_Type_Id)
                ?? throw new Ref_Service_Type_NotFoundException(appointmentDto.Ref_Service_Type_Id);

            var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
            var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
            appointmentDto.ServiceProviderDisplayDto = serviceProviderDto;
            appointmentDto.Ref_Service_Type_Display_Dto = serviceTypeDto;
            
            return appointmentDto;
        }
    }
}
