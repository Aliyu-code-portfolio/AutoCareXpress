using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions
{
    public class VerificationFailException:Exception
    {
        public VerificationFailException(string message):base(message)
        {
            
        }
    }
}
