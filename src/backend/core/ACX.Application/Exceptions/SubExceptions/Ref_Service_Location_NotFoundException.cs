using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class Ref_Service_Location_NotFoundException:NotFoundException
    {
        public Ref_Service_Location_NotFoundException(int id) : base($"The service location with id {id} is not found in the database")
        {

        }
        public Ref_Service_Location_NotFoundException(object identity) : base($"The service location with identity {identity} is not found in the database")
        {
            
        }
    }
}
