using ACX.Application.DTOs.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IRef_Service_Type_Service
    {
        Task<IEnumerable<Ref_Service_Type_Display_Dto>> GetAllServiceTypes();
        Task<Ref_Service_Type_Display_Dto> GetServiceTypeById(int id);
        Task<Ref_Service_Type_Display_Dto> GetServiceTypeByName(string name);
    }
}
