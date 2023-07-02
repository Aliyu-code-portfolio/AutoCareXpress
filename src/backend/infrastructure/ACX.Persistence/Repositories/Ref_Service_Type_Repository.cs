using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using Microsoft.EntityFrameworkCore;


namespace ACX.Persistence.Repositories
{
    internal sealed class Ref_Service_Type_Repository : RepositoryBase<Ref_Service_Type>, IRef_Service_Type_Repository
    {
        public Ref_Service_Type_Repository(RepositoryContext context):base(context)
        {
            
        }
        public async Task<IEnumerable<Ref_Service_Type>> GetAllServiceType()
        {
            var services = await FindAll(false).ToListAsync();
            return services;
        }

        public Task<Ref_Service_Type> GetServiceTypeById(int id)
        {
            var service = FindByCondition(s=>s.Id.Equals(id),false).FirstOrDefaultAsync();
            return service;
        }

        public Task<Ref_Service_Type> GetServiceTypeByName(string name)
        {
            var service = FindByCondition(s=>s.ServiceName.Contains(name),false).FirstOrDefaultAsync();
            return service;
        }
    }
}
