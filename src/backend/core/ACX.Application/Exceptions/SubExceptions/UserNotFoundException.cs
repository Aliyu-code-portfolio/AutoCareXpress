using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class UserNotFoundException:NotFoundException
    {
        public UserNotFoundException(Guid id) : base($"The user with id {id} is not found in the database")
        {

        }
        public UserNotFoundException(object identity): base($"The user with identity {identity} is not found in the database")
        {
            
        }
    }
}
