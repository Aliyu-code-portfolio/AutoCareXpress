using ACX.Application.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Common
{
    public interface IRepositoryManager
    {
        public IPickUpAddress_Repository PickUpAddress_Repository { get; }
        public IVehicle_Repository Vehicle_Repository { get; }
        public IRef_Service_Type_Repository Ref_Service_Type_Repository { get;}
        public IRef_Service_Location_Repository Ref_Service_Location_Repository { get; }  }
}
