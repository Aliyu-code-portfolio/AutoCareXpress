using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using ACX.Shared.RequestFeatures;
using ACX.Shared.RequestFeatures.ModelRequestParameters;
using AutoMapper;
using System;

namespace ACX.Service.Services
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        /*public async Task<UserDisplayDto> CreateUser(UserRegistrationDto userCreationDto)
        {
            var user = _mapper.Map<User>(userCreationDto);
            _repositoryManager.UserRepository.CreateUser(user);
            await _repositoryManager.SaveChangesAsync();
            var userDto = _mapper.Map<UserDisplayDto>(user);
            return userDto;
        }*/

        public async Task DeleteUser(string id)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            _repositoryManager.UserRepository.DeleteUser(user);
            await _repositoryManager.SaveChangesAsync();    
        }

        public async Task<(IEnumerable<UserDisplayDto> Users,MetaData MetaData)> GetAllUsers(UserRequestParameter requestParameter)
        {
            var users = await _repositoryManager.UserRepository.GetAllUserAsync(requestParameter, false);
            var usersDto = _mapper.Map<IEnumerable<UserDisplayDto>>(users);
            return (usersDto,users.MetaData);
        }

        public async Task<UserDisplayDto> GetUserByEmail(string email)
        {
            var user = await _repositoryManager.UserRepository.GetUserByEmailAsync(email, false)
                ?? throw new UserNotFoundException(email);
            var userDto = _mapper.Map<UserDisplayDto>(user);
            var address = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(user.Id, false);
            var addressDto = _mapper.Map<PickUpAddressDisplayDto>(address);
            userDto.Address = addressDto??null;

            return userDto;
        }

        public async Task<UserDisplayDto> GetUserById(string id)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            var userDto = _mapper.Map<UserDisplayDto>(user);
            var address = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(user.Id, false);
            var addressDto = _mapper.Map<PickUpAddressDisplayDto>(address);
            userDto.Address = addressDto ?? null;
            return userDto;
        }

        public async Task UpdateUser(UserUpdateDto userUpdateDto)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(userUpdateDto.Id, false)
                ?? throw new UserNotFoundException(userUpdateDto.Id);
            var userFromDto = _mapper.Map<User>(userUpdateDto);
            _repositoryManager.UserRepository.UpdateUser(userFromDto);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}
