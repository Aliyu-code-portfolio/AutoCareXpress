using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.ServiceContract.Interfaces
{
    public interface IUserService
    {
        Task<(IEnumerable<UserDisplayDto> Users, MetaData MetaData)> GetAllUsers(UserRequestParameter requestParameter);
        Task<UserDisplayDto> GetUserById(string id);
        Task<UserDisplayDto> GetUserByEmail(string email);
        //Task<UserDisplayDto> CreateUser(UserRegistrationDto userCreationDto);
        Task UpdateUser(UserUpdateDto userUpdateDto);
        Task DeleteUser(string id);
    }
}
