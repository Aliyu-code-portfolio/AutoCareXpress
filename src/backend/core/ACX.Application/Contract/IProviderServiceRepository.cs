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
        Task<IEnumerable<ProviderService>> GetAllAsync(bool trackChanges);
        Task<ProviderService> GetProviderServiceByIdAsync(int id, bool trackChanges);
        Task<ProviderService> GetProviderServiceByMinPriceAsync(decimal minPrice, bool trackChanges);
        void CreateProviderService(ProviderService providerService);
        void DeleteProviderService(ProviderService providerService);
    }
}
