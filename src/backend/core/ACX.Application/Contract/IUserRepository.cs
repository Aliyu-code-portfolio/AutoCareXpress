using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync(bool trackChanges);
        Task<User> GetUserByIdAsync(int id, bool trackChanges);
        Task<User> GetUserByEmailAsync(string email, bool trackChanges);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
