using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions.SubExceptions
{
    public class RefreshTokenBadRequest:BadRequest
    {
        public RefreshTokenBadRequest()
: base("Invalid client request. The tokenDto has some invalid values.")
        {
        }
    }
}
