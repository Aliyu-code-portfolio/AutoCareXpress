using ACX.ServiceContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Common
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IServiceProviderService ServiceProviderService { get; }
        IProviderServiceService ProviderServiceService { get; }
        IRef_Service_Location_Service Ref_Service_Location_Service { get; }
        IRef_Service_Type_Service Ref_Service_Type_Service { get; }
        IPickUpAddressService PickUpAddressService { get; }
        IVehicleService VehicleService { get; }
        IAppointmentService AppointmentService { get; }
        IDoYouKnowService DoYouKnowService { get; }
    }
}
