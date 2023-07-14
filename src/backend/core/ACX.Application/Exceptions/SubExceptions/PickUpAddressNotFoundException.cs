using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class PickUpAddressNotFoundException:NotFoundException
    {
        public PickUpAddressNotFoundException(string id):base($"The pickup address for user {id} is not found in the database")
        {
            
        }
    }
}
