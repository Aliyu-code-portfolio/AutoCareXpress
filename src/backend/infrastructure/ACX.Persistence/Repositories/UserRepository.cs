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
    public class UserRepository :RepositoryBase<User>, IUserRepository
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

        public async Task<IEnumerable<User>> GetAllUserAsync(bool trackChanges)
        {
            var users = await FindAll(trackChanges).ToListAsync();
            return users;
        }

        public async Task<User> GetUserByIdAsync(int id, bool trackChanges)
        {
            var user = await FindByCondition(u => u.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email, bool trackChanges)
        {
            var user = await FindByCondition(u => u.Email.Contains(email), trackChanges).FirstOrDefaultAsync();
            return user;
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }
    }
}
