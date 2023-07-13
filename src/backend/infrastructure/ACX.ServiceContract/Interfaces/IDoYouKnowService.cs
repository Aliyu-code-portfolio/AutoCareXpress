using ACX.Application.DTOs.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IDoYouKnowService
    {
        Task<IEnumerable<DoYouKnowDisplayDto>> GetAllDoYouKnow();
        Task<DoYouKnowDisplayDto> GetLatestDoYouKnow();
        Task<DoYouKnowDisplayDto> GetRandomDoYouKnow();
    }
}
