using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class VehicleNotFoundException:NotFoundException
    {
        public VehicleNotFoundException(int id) : base($"The vehicle with id {id} is not found in the database")
        {

        }
    }
}
