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
    public interface IProviderServiceService
    {
        Task<IEnumerable<ProviderServiceDisplayDto>> GetAllProviderServices(bool trackChanges);
        Task<IEnumerable<ProviderServiceDisplayDto>> GetProviderServicesByServiceProviderId(Guid providerId, bool trackChanges);
        Task<IEnumerable<ProviderServiceDisplayDto>> GetProviderServicesByServiceType(int serviceTypeId, bool trackChanges);
        Task<ProviderServiceDisplayDto> GetProviderServiceById(int id, bool trackChanges);
        Task<ProviderServiceDisplayDto> CreateProviderService(ProviderServiceCreationDto providerServiceCreationDto);
        //void UpdateProviderService(ProviderServiceUpdateDto providerServiceUpdateDto);
        void DeleteProviderService(int id);
    }
}
