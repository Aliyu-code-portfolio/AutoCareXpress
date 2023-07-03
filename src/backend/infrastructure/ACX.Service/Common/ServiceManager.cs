using ACX.Application.Common;
using ACX.Service.Services;
using ACX.ServiceContract.Common;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Common
{
    public class ServiceManager : IServiceManager
    {
        private Lazy<IUserService> userService;

        private Lazy<IServiceProviderService> serviceProviderService;

        private Lazy<IProviderServiceService> providerServiceService;

        private Lazy<IRef_Service_Location_Service> ref_Service_Location_Service;

        private Lazy<IRef_Service_Type_Service> ref_Service_Type_Service;

        private Lazy<IPickUpAddressService> pickUpAddressService;

        private Lazy<IVehicleService> vehicleService;

        private Lazy<IAppointmentService> appointmentService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            userService = new Lazy<IUserService>(()=>new UserService(repositoryManager, mapper));
            serviceProviderService=new Lazy<IServiceProviderService>(()=>new ServiceProviderService(repositoryManager,mapper));
            providerServiceService = new Lazy<IProviderServiceService>(()=>new ProviderServiceService(repositoryManager,mapper));
            ref_Service_Location_Service = new Lazy<IRef_Service_Location_Service>(() => new Ref_Service_Location_Service(repositoryManager, mapper));
            ref_Service_Type_Service = new Lazy<IRef_Service_Type_Service>(()=>new Ref_Service_Type_Service(repositoryManager, mapper));
            pickUpAddressService = new Lazy<IPickUpAddressService>(() => new PickUpAddressService(repositoryManager, mapper));
            vehicleService = new Lazy<IVehicleService>(() => new VehicleService(repositoryManager, mapper));
            appointmentService = new Lazy<IAppointmentService>(() => new AppointmentService(repositoryManager, mapper));
        }
        public IUserService UserService => userService.Value;

        public IServiceProviderService ServiceProviderService => serviceProviderService.Value;

        public IProviderServiceService ProviderServiceService => providerServiceService.Value;

        public IRef_Service_Location_Service Ref_Service_Location_Service => ref_Service_Location_Service.Value;

        public IRef_Service_Type_Service Ref_Service_Type_Service => ref_Service_Type_Service.Value;

        public IPickUpAddressService PickUpAddressService => pickUpAddressService.Value;

        public IVehicleService VehicleService => vehicleService.Value;

        public IAppointmentService AppointmentService => appointmentService.Value;
    }
}
