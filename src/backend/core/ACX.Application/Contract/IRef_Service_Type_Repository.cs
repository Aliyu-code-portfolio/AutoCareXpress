using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IRef_Service_Type_Repository
    {
        Task<IEnumerable<Ref_Service_Type>> GetAllServiceType();
        Task<Ref_Service_Type> GetServiceTypeById(int id);
        Task<Ref_Service_Type> GetServiceTypeByName(string name);

    }
}
