using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions
{
    public class CannotCreateException:Exception
    {
        public CannotCreateException(string message):base(message)
        {
            
        }
        public CannotCreateException():base("Could not create the object")
        {
            
        }
    }
}
