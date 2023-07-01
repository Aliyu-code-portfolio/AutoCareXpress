using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IProviderServiceRepository
    {
        Task<IEnumerable<ProviderService>> GetAllProviderServiceAsync(bool trackChanges);
        Task<IEnumerable<ProviderService>> GetAllProviderServiceByServiceTypeIdAsync(int id, bool trackChanges);
        Task<ProviderService> GetProviderServiceByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<ProviderService>> GetAllProviderServiceByProviderIdAsync(Guid providerId, bool trackChanges);
        Task<ProviderService> GetProviderServiceByMinPriceAsync(decimal minPrice, bool trackChanges);
        void CreateProviderService(ProviderService providerService);
        void DeleteProviderService(ProviderService providerService);
    }
}
