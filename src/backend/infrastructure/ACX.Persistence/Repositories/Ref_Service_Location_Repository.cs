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
    internal sealed class Ref_Service_Location_Repository : RepositoryBase<Ref_Service_Location>, IRef_Service_Location_Repository
    {
        public Ref_Service_Location_Repository(RepositoryContext context):base(context)
        {
            
        }
        public async Task<IEnumerable<Ref_Service_Location>> GetAllServiceLocation()
        {
            var locations = await FindAll(false).ToListAsync();
            return locations;
        }

        public async Task<Ref_Service_Location> GetServiceLocationById(int id)
        {
            var location = await FindByCondition(l=>l.Id.Equals(id),false).FirstOrDefaultAsync();
            return location;
        }

        public async Task<Ref_Service_Location> GetServiceLocationByName(string name)
        {
            var location = await FindByCondition(l=>l.Location.Contains(name),false).FirstOrDefaultAsync();
            return location;
        }
    }
}
