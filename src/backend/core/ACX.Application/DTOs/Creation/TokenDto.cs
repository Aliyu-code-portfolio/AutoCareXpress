using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.DTOs.Creation
{
    public record TokenDto(string AccessToken, string RefreshToken);

}
