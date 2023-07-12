using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
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

        public async Task<PagedList<ServiceProvider>> GetAllServiceProviderAsync(ProviderRequestParameter requestParameter, bool trackChanges)
        {
            var serviceProviders = await FindAll(trackChanges).Skip((requestParameter.PageNumber-1)*requestParameter.PageSize)
                .Take(requestParameter.PageSize).ToListAsync();
            var count = await FindAll(false).CountAsync();

            return new PagedList<ServiceProvider>(serviceProviders, count, requestParameter.PageNumber,requestParameter.PageSize);
        }

        public async Task<ServiceProvider> GetServiceProviderByIdAsync(string id, bool trackChanges)
        {
            var serviceProvider = await FindByCondition(s => s.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return serviceProvider;
        }

        public async Task<ServiceProvider> GetServiceProviderByEmailAsync(string email, bool trackChanges)
        {
            var serviceProvider = await FindByCondition(s => s.CompanyEmail.ToLower().Contains(email.ToLower()), trackChanges).FirstOrDefaultAsync();
            return serviceProvider;
        }

        public async Task<ServiceProvider> GetServiceProviderByRegNumberAsync(string regNumber, bool trackChanges)
        {
            var serviceProvider = await FindByCondition(s => s.RegistrationNumber.ToLower().Contains(regNumber.ToLower()), trackChanges).FirstOrDefaultAsync();
            return serviceProvider;
        }

        public void UpdateServiceProvider(ServiceProvider serviceProvider)
        {
            Update(serviceProvider);
        }
    }
}
