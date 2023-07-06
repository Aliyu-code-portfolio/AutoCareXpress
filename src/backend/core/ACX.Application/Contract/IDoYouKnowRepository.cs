using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IDoYouKnowRepository
    {
        Task<IEnumerable<DoYouKnow>> GetAllDoYouKnow();
        Task<DoYouKnow?> GetLatestDoYouKnow();
    }
}
