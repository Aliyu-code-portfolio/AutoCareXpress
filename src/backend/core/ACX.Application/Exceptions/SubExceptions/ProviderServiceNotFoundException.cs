using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class ProviderServiceNotFoundException:NotFoundException
    {
        public ProviderServiceNotFoundException(int id) : base($"The service with id {id} is not found in the database")
        {

        }
    }
}
