using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IRef_Service_Location_Repository
    {
        Task<IEnumerable<Ref_Service_Location>> GetAllServiceLocation();
        Task<Ref_Service_Location> GetServiceLocationById(int id);
        Task<Ref_Service_Location> GetServiceLocationByName(string name);
    }
}
