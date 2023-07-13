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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Services
{
    internal sealed class ServiceProviderService : IServiceProviderService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ServiceProviderService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<ServiceProviderDisplayDto> CreateServiceProvider(ServiceProviderCreationDto serviceProviderCreationDto)
        {
            var serviceProvider = _mapper.Map<ServiceProvider>(serviceProviderCreationDto);
            serviceProvider.Id=Guid.NewGuid().ToString();
            Console.WriteLine(Guid.NewGuid().ToString());
            _repositoryManager.ServiceProviderRepository.CreateServiceProvider(serviceProvider);
            await _repositoryManager.SaveChangesAsync();
            var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
            return serviceProviderDto;
        }

        public async Task DeleteServiceProvider(string id)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository.GetServiceProviderByIdAsync(id, false)
                ?? throw new ServiceProviderNotFoundException(id);
            _repositoryManager.ServiceProviderRepository.DeleteServiceProvider(serviceProvider);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<ServiceProviderDisplayDto> GerServiceProviderByRegNumber(string regNumber)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetServiceProviderByRegNumberAsync(regNumber, false)
                ?? throw new ServiceProviderNotFoundException(regNumber);
            var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
            return serviceProviderDto;
        }

        public async Task<(IEnumerable<ServiceProviderDisplayDto> Providers, MetaData MetaData)> GetAllServiceProviders(ProviderRequestParameter requestParameter)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetAllServiceProviderAsync(requestParameter, false);
            var serviceProviderDto = _mapper.Map<IEnumerable<ServiceProviderDisplayDto>>(serviceProvider);
            return (serviceProviderDto, serviceProvider.MetaData);
        }

        public async Task<IEnumerable<ServiceProviderDisplayDto>> GetProductByLocation(int id)
        {
            var providers = await _repositoryManager.ServiceProviderRepository.GetAllServiceByLocation(id);
            var providersDto = _mapper.Map<IEnumerable<ServiceProviderDisplayDto>>(providers);
            return providersDto;
        }

        public async Task<ServiceProviderDisplayDto> GetServiceProviderByEmail(string email)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetServiceProviderByEmailAsync(email, false)
                ?? throw new ServiceProviderNotFoundException(email);
            var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
            return serviceProviderDto;
        }

        public async Task<ServiceProviderDisplayDto> GetServiceProviderById(string id)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetServiceProviderByIdAsync(id, false)
                ?? throw new ServiceProviderNotFoundException(id);
            var serviceProviderDto = _mapper.Map<ServiceProviderDisplayDto>(serviceProvider);
            return serviceProviderDto;
        }

        public async Task UpdateServiceProvider(ServiceProviderUpdateDto serviceProviderUpdateDto)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository.GetServiceProviderByIdAsync(serviceProviderUpdateDto.Id, false)
                ?? throw new ServiceProviderNotFoundException(serviceProviderUpdateDto.Id);
            var serviceProviderFromDto = _mapper.Map<ServiceProvider>(serviceProviderUpdateDto);
            _repositoryManager.ServiceProviderRepository.UpdateServiceProvider(serviceProviderFromDto);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task UpdateStatus(string id, bool flag)
        {
            var serviceProvider = await _repositoryManager.ServiceProviderRepository
                .GetServiceProviderByIdAsync(id, false)
                ?? throw new ServiceProviderNotFoundException(id);
            serviceProvider.IsAvailable=flag;
            _repositoryManager.ServiceProviderRepository.UpdateServiceProvider(serviceProvider);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}

