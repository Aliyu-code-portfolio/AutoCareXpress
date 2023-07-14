using ACX.Domain.Model;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUserAsync(UserRequestParameter requestParameter, bool trackChanges);
        Task<User> GetUserByIdAsync(string id, bool trackChanges);
        Task<User> GetUserByEmailAsync(string email, bool trackChanges);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
