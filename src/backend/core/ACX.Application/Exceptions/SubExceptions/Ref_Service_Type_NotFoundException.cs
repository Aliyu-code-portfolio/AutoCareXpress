using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class Ref_Service_Type_NotFoundException:NotFoundException
    {
        public Ref_Service_Type_NotFoundException(int id) : base($"The service type with id {id} is not found in the database")
        {

        }
        public Ref_Service_Type_NotFoundException(object identity) : base($"The service type with identity {identity} is not found in the database")
        {
            
        }
    }
}
