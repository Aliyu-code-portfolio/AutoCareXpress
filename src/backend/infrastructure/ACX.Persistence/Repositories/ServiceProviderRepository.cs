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
    internal sealed class ServiceProviderRepository : RepositoryBase<ServiceProvider>, IServiceProviderRepository
    {
        public ServiceProviderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateServiceProvider(ServiceProvider serviceProvider)
        {
            Create(serviceProvider);
        }

        public void DeleteServiceProvider(ServiceProvider serviceProvider)
        {
            Delete(serviceProvider);
        }

        public async Task<IEnumerable<ServiceProvider>> GetAllServiceProviderAsync(bool trackChanges)
        {
            var serviceProviders = await FindAll(trackChanges).ToListAsync();
            return serviceProviders;
        }

        public async Task<ServiceProvider> GetServiceProviderByIdAsync(Guid id, bool trackChanges)
        {
            var serviceProvider = await FindByCondition(s => s.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return serviceProvider;
        }

        public async Task<ServiceProvider> GetServiceProviderByEmailAsync(string email, bool trackChanges)
        {
            var serviceProvider = await FindByCondition(s => s.CompanyEmail.Contains(email), trackChanges).FirstOrDefaultAsync();
            return serviceProvider;
        }

        public async Task<ServiceProvider> GetServiceProviderByRegNumberAsync(string regNumber, bool trackChanges)
        {
            var serviceProvider = await FindByCondition(s => s.RegistrationNumber.Contains(regNumber), trackChanges).FirstOrDefaultAsync();
            return serviceProvider;
        }

        public void UpdateServiceProvider(ServiceProvider serviceProvider)
        {
            Update(serviceProvider);
        }
    }
}
