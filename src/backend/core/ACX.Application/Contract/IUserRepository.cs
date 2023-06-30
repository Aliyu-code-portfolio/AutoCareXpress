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
        Task<IEnumerable<User>> GetAllAsync(bool trackChanges);
        Task<User> GetUserByIdAsync(int id, bool trackChanges);
        Task<User> GetUserByNameAsync(string name, bool trackChanges);
        Task<User> GetUserByPhoneAsync(int phone, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
