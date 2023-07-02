using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class ServiceProviderNotFoundException:NotFoundException
    {
        public ServiceProviderNotFoundException(Guid id) : base($"The service provider with id {id} is not found in the database")
        {

        }
        public ServiceProviderNotFoundException(object identity) : base($"The service provider with identity {identity} is not found in the database")
        {
            
        }
    }
}
