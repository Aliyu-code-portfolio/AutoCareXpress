using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Services
{
    internal sealed class ProviderServiceService : IProviderServiceService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ProviderServiceService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<ProviderServiceDisplayDto> CreateProviderService(ProviderServiceCreationDto providerServiceCreationDto)
        {
            var service = _mapper.Map<ProviderService>(providerServiceCreationDto);
            _repositoryManager.ProviderServiceRepository.CreateProviderService(service);
            await _repositoryManager.SaveChangesAsync();
            var serviceDto = _mapper.Map<ProviderServiceDisplayDto>(service);
            return serviceDto;
        }

        public async void DeleteProviderService(int id)
        {
            var service = await _repositoryManager.ProviderServiceRepository.GetProviderServiceByIdAsync(id, false)
                ?? throw new ProviderServiceNotFoundException(id);
            _repositoryManager.ProviderServiceRepository.DeleteProviderService(service);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProviderServiceDisplayDto>> GetAllProviderServices(bool trackChanges)
        {
            var services = await _repositoryManager.ProviderServiceRepository.GetAllProviderServiceAsync(false);
            var servicesDto = _mapper.Map<IEnumerable<ProviderServiceDisplayDto>>(services);
            foreach (var serviceDto in servicesDto)
            {
                var serviceProvider = await _repositoryManager.ServiceProviderRepository
                    .GetServiceProviderByIdAsync(serviceDto.ServiceProviderId, trackChanges)
                    ??throw new ServiceProviderNotFoundException(serviceDto.ServiceProviderId);
                var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetServiceTypeById(serviceDto.Ref_Service_Type_ID)
                    ?? throw new Ref_Service_Type_NotFoundException(serviceDto.Ref_Service_Type_ID);
                var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
                var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
                serviceDto.ServiceProviderDisplayDto=serviceProviderDto;
                serviceDto.Ref_Service_Type_Display_Dto=serviceTypeDto;
            }
            return servicesDto;
        }

        public async Task<ProviderServiceDisplayDto> GetProviderServiceById(int id,bool trackChanges)
        {
            var service = await _repositoryManager.ProviderServiceRepository.GetProviderServiceByIdAsync(id, false);
            var serviceDto = _mapper.Map<ProviderServiceDisplayDto>(service);
            
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetServiceProviderByIdAsync(serviceDto.ServiceProviderId, trackChanges)
                ?? throw new ServiceProviderNotFoundException(serviceDto.ServiceProviderId);
            var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetServiceTypeById(serviceDto.Ref_Service_Type_ID)
                ?? throw new Ref_Service_Type_NotFoundException(serviceDto.Ref_Service_Type_ID);
            var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
            var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
            serviceDto.ServiceProviderDisplayDto = serviceProviderDto;
            serviceDto.Ref_Service_Type_Display_Dto = serviceTypeDto;
           
            return serviceDto;
        }

        public async Task<IEnumerable<ProviderServiceDisplayDto>> GetProviderServicesByServiceProviderId(Guid providerId, bool trackChanges)
        {
            var services = await _repositoryManager.ProviderServiceRepository.GetAllProviderServiceByProviderIdAsync(providerId, false);
            var servicesDto = _mapper.Map<IEnumerable<ProviderServiceDisplayDto>>(services);
            foreach (var serviceDto in servicesDto)
            {
                var serviceProvider = await _repositoryManager.ServiceProviderRepository
                    .GetServiceProviderByIdAsync(serviceDto.ServiceProviderId, trackChanges)
                    ?? throw new ServiceProviderNotFoundException(serviceDto.ServiceProviderId);
                var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetServiceTypeById(serviceDto.Ref_Service_Type_ID)
                    ?? throw new Ref_Service_Type_NotFoundException(serviceDto.Ref_Service_Type_ID);
                var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
                var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
                serviceDto.ServiceProviderDisplayDto = serviceProviderDto;
                serviceDto.Ref_Service_Type_Display_Dto = serviceTypeDto;
            }
            return servicesDto;
        }

        public async Task<IEnumerable<ProviderServiceDisplayDto>> GetProviderServicesByServiceType(int serviceTypeId, bool trackChanges)
        {
            var services = await _repositoryManager.ProviderServiceRepository.GetAllProviderServiceByServiceTypeIdAsync(serviceTypeId, false);
            var servicesDto = _mapper.Map<IEnumerable<ProviderServiceDisplayDto>>(services);
            foreach (var serviceDto in servicesDto)
            {
                var serviceProvider = await _repositoryManager.ServiceProviderRepository
                    .GetServiceProviderByIdAsync(serviceDto.ServiceProviderId, trackChanges)
                    ?? throw new ServiceProviderNotFoundException(serviceDto.ServiceProviderId);
                var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetServiceTypeById(serviceDto.Ref_Service_Type_ID)
                    ?? throw new Ref_Service_Type_NotFoundException(serviceDto.Ref_Service_Type_ID);
                var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
                var serviceTypeDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
                serviceDto.ServiceProviderDisplayDto = serviceProviderDto;
                serviceDto.Ref_Service_Type_Display_Dto = serviceTypeDto;
            }
            return servicesDto;
        }

        /*public async void UpdateProviderService(ProviderServiceUpdateDto providerServiceUpdateDto)
        {
            var service = await _repositoryManager.ProviderServiceRepository.GetProviderServiceByIdAsync(providerServiceUpdateDto.Id,false)
                ??throw new ProviderServiceNotFoundException(providerServiceUpdateDto.Id);
            var serviceFromDto = _mapper.Map<ProviderService>(providerServiceUpdateDto);
            _repositoryManager.ProviderServiceRepository.U
        }*/
    }
}
