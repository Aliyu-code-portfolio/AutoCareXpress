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
    public interface IServiceProviderService
    {
        Task<(IEnumerable<ServiceProviderDisplayDto> Providers, MetaData MetaData)> GetAllServiceProviders(ProviderRequestParameter requestParameter);
        Task<IEnumerable<ServiceProviderDisplayDto>> GetProductByLocation(int id);
        Task<ServiceProviderDisplayDto> GetServiceProviderById(string id);
        Task<ServiceProviderDisplayDto> GetServiceProviderByEmail(string email);
        Task<ServiceProviderDisplayDto> GerServiceProviderByRegNumber(string regNumber);
        Task<ServiceProviderDisplayDto> CreateServiceProvider(ServiceProviderCreationDto serviceProviderCreationDto);
        Task UpdateServiceProvider(ServiceProviderUpdateDto serviceProviderUpdateDto);
        Task DeleteServiceProvider(string id);
        Task UpdateStatus(string id,bool flag);
    }
}
