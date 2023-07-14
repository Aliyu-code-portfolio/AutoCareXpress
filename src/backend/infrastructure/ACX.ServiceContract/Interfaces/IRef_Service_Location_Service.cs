using ACX.Application.DTOs.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IRef_Service_Location_Service
    {
        Task<IEnumerable<Ref_Service_Location_Display_Dto>> GetAllServiceLocations();
        Task<Ref_Service_Location_Display_Dto> GetServiceLocationById(int id);
        Task<Ref_Service_Location_Display_Dto> GerServiceLocationByName(string name);
    }
}
