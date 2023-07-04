using ACX.Application.Common;
using ACX.Application.Contract;
using ACX.Persistence.Repositories;
using System;

namespace ACX.Persistence.Common
{
    public class RepositoryManager : IRepositoryManager
    {
        private Lazy<IUserRepository> userRepository;
        private Lazy<IServiceProviderRepository> serviceProviderRepository;
        private Lazy<IPickUpAddress_Repository> pickUpAddress_Repository;
        private Lazy<IVehicle_Repository> vehicleRepository;
        private Lazy<IAppointmentRepository> appointmentRepository;
        private Lazy<IProviderServiceRepository> providerServiceRepository;
        private Lazy<IRef_Service_Location_Repository> refServiceLocationRepository;
        private Lazy<IRef_Service_Type_Repository> refServiceTypeRepository;

        private readonly RepositoryContext _context;
        public RepositoryManager(RepositoryContext context)
        {
            userRepository = new Lazy<IUserRepository>(()=> new UserRepository(context));
            serviceProviderRepository = new Lazy<IServiceProviderRepository>(()=> new ServiceProviderRepository(context));
            pickUpAddress_Repository = new Lazy<IPickUpAddress_Repository>(()=> new PickUpAddress_Repository(context));
            vehicleRepository =new Lazy<IVehicle_Repository>(()=>new  VehicleRepsoitory(context));
            appointmentRepository = new Lazy<IAppointmentRepository>(()=>new AppointmentRepository(context));
            providerServiceRepository =new Lazy<IProviderServiceRepository>(()=>new ProviderServiceRepository(context));
            refServiceLocationRepository = new Lazy<IRef_Service_Location_Repository>(()=>new Ref_Service_Location_Repository(context));
            refServiceTypeRepository = new Lazy<IRef_Service_Type_Repository>(()=>new Ref_Service_Type_Repository(context));
            _context = context;
        }


        public IUserRepository UserRepository => userRepository.Value;

        public IAppointmentRepository AppointmentRepository => appointmentRepository.Value;

        public IServiceProviderRepository ServiceProviderRepository => serviceProviderRepository.Value;

        public IProviderServiceRepository ProviderServiceRepository => providerServiceRepository.Value;

        public IPickUpAddress_Repository PickUpAddress_Repository => pickUpAddress_Repository.Value;

        public IVehicle_Repository Vehicle_Repository => vehicleRepository.Value;

        public IRef_Service_Type_Repository Ref_Service_Type_Repository => refServiceTypeRepository.Value;

        public IRef_Service_Location_Repository Ref_Service_Location_Repository => refServiceLocationRepository.Value;

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
