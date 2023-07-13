using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Repositories
{
    internal sealed class ProviderServiceRepository : RepositoryBase<ProviderService>, IProviderServiceRepository
    {
        public ProviderServiceRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProviderService(ProviderService providerService)
        {
            Create(providerService);
        }

        public void DeleteProviderService(ProviderService providerService)
        {
            Delete(providerService);
        }

        public async Task<IEnumerable<ProviderService>> GetAllProviderServiceAsync(bool trackChanges)
        {
            var providerServices = await FindAll(trackChanges).Include(s => s.ServiceProvider).Include(s => s.Ref_Service_Type).ToListAsync();
            return providerServices;
        }
        
        public async Task<IEnumerable<ProviderService>> GetAllProviderServiceByProviderIdAsync(string providerId, bool trackChanges)
        {
            var providerService = await FindByCondition(p => p.ServiceProviderId.Equals(providerId), trackChanges).Include(s => s.ServiceProvider).Include(s => s.Ref_Service_Type).ToListAsync();
            return providerService;
        }
        public async Task<IEnumerable<ProviderService>> GetAllProviderServiceByServiceTypeIdAsync(int id, bool trackChanges)
        {
            var providerServices = await FindByCondition(p => p.Ref_Service_Type_ID.Equals(id), trackChanges).Include(s=>s.ServiceProvider).Include(s=>s.Ref_Service_Type).ToListAsync();
            return providerServices;
        }

        public async Task<ProviderService> GetProviderServiceByIdAsync(int id, bool trackChanges)
        {
            var providerService = await FindByCondition(p => p.Id.Equals(id), trackChanges).Include(s => s.ServiceProvider).Include(s => s.Ref_Service_Type).FirstOrDefaultAsync();
            return providerService;
        }

        public async Task<ProviderService> GetProviderServiceByMinPriceAsync(decimal minPrice, bool trackChanges)
        {
            var providerServices = await FindByCondition(p => p.MinPrice >= minPrice, trackChanges).Include(s => s.ServiceProvider).Include(s => s.Ref_Service_Type).FirstOrDefaultAsync();
            return providerServices;
        }

    }
}
