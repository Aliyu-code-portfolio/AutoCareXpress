using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDisplayDto>> GetAllUsers();
        Task<UserDisplayDto> GetUserById(Guid id);
        Task<UserDisplayDto> GetUserByEmail(string email);
        Task<UserDisplayDto> CreateUser(UserCreationDto userCreationDto);
        void UpdateUser(UserUpdateDto userUpdateDto);
        void DeleteUser(Guid id);
    }
}
