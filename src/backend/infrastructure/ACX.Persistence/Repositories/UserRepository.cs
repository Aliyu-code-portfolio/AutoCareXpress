using ACX.Application.Contract;
using ACX.Domain.Model;
using ACX.Persistence.Common;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Repositories
{
    internal sealed class UserRepository :RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context):base(context)
        {
            
        }
        public void CreateUser(User user)
        {
            Create(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public async Task<PagedList<User>> GetAllUserAsync(UserRequestParameter requestParameter, bool trackChanges)
        {
            var users = await FindAll(trackChanges).Skip((requestParameter.PageNumber-1)*requestParameter.PageSize)
                .Take(requestParameter.PageSize).Where(p => p.Name.ToLower().Contains(requestParameter.SearchTerm.ToLower())).ToListAsync();
            var count = await FindAll(false).CountAsync();
            return new PagedList<User>(users,count,requestParameter.PageNumber,requestParameter.PageSize);
        }

        public async Task<User> GetUserByIdAsync(string id, bool trackChanges)
        {
            var user = await FindByCondition(u => u.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email, bool trackChanges)
        {
            var user = await FindByCondition(u => u.Email.ToLower().Contains(email.ToLower()), trackChanges).FirstOrDefaultAsync();
            return user;
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }
    }
}
