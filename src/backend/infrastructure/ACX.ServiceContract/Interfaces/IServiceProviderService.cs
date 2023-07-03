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
    public interface IServiceProviderService
    {
        Task<IEnumerable<ServiceProviderDisplayDto>> GetAllServiceProviders();
        Task<ServiceProviderDisplayDto> GetServiceProviderById(Guid id);
        Task<ServiceProviderDisplayDto> GetServiceProviderByEmail(string email);
        Task<ServiceProviderDisplayDto> GerServiceProviderByRegNumber(string regNumber);
        Task<ServiceProviderDisplayDto> CreateServiceProvider(ServiceProviderCreationDto serviceProviderCreationDto);
        void UpdateServiceProvider(ServiceProviderUpdateDto serviceProviderUpdateDto);
        void DeleteServiceProvider(Guid id);
    }
}
