using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Domain.Model;
using AutoMapper;
using ServiceProvider = ACX.Domain.Model.ServiceProvider;

namespace ACX.WebAPI.ProfileMapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User,UserDisplayDto>();
            CreateMap<UserRegistrationDto, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<ServiceProvider, ServiceProviderDisplayDto>();
            CreateMap<ServiceProviderCreationDto, ServiceProvider>();
            CreateMap<ServiceProviderUpdateDto, ServiceProvider>();
            CreateMap<PickUpAddress, PickUpAddressDisplayDto>();
            CreateMap<PickUpAddressCreationDto, PickUpAddress>();
            CreateMap<PickUpAddressUpdateDto, PickUpAddress>();
            CreateMap<Vehicle, VehicleDisplayDto>();
            CreateMap<VehicleCreationDto, Vehicle>();
            CreateMap<VehicleUpdateDto, Vehicle>();
            CreateMap<Appointment, AppointmentDisplayDto>();
            CreateMap<AppointmentCreationDto, Appointment>();
            CreateMap<AppointmentUpdateDto, Appointment>();
            CreateMap<ProviderService, ProviderServiceDisplayDto>();
            CreateMap<ProviderServiceCreationDto, ProviderService>();
            CreateMap<ProviderServiceUpdateDto, ProviderService>();
            CreateMap<Ref_Service_Location, Ref_Service_Location_Display_Dto>();
            CreateMap<Ref_Service_Type, Ref_Service_Type_Display_Dto>();
            CreateMap<DoYouKnow, DoYouKnowDisplayDto>();
        }
    }
}
