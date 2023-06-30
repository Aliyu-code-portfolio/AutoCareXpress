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
        public IUserRepository UserRepository { get; }
        public IAppointmentRepository AppointmentRepository { get; }
        public IServiceProviderRepository ServiceProviderRepository { get; }
        public IProviderServiceRepository ProviderServiceRepository { get; }
        public IRef_Service_Type_Repository IRef_Service_Type_Repository { get;}
        public IRef_Service_Location_Repository IRef_Service_Location_Repository { get; }  
    }
}
