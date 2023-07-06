using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Repositories
{
    internal sealed class DoYouKnowRepository :RepositoryBase<DoYouKnow>, IDoYouKnowRepository
    {
        private readonly RepositoryContext _context;
        public DoYouKnowRepository(RepositoryContext context):base(context)
        {
        }
        public async Task<IEnumerable<DoYouKnow>> GetAllDoYouKnow()
        {
            return await FindAll(false).ToListAsync();
        }

        public async Task<DoYouKnow?> GetLatestDoYouKnow()
        {
            return await FindAll(false).OrderByDescending(d => d.CreatedDate).Take(1).FirstOrDefaultAsync();
        }
    }
}
