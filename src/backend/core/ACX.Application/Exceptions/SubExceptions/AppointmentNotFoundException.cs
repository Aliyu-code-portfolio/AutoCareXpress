using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class AppointmentNotFoundException:NotFoundException
    {
        public AppointmentNotFoundException(int id):base($"The appointment with ID {id} is not found in the database")
        {
            
        }
    }
}
