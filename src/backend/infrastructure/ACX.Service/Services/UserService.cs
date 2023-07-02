using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
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
        public async Task<UserDisplayDto> CreateUser(UserCreationDto userCreationDto)
        {
            var user = _mapper.Map<User>(userCreationDto);
            _repositoryManager.UserRepository.CreateUser(user);
            await _repositoryManager.SaveChangesAsync();
            var userDto = _mapper.Map<UserDisplayDto>(user);
            return userDto;
        }

        public async void DeleteUser(Guid id)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            _repositoryManager.UserRepository.DeleteUser(user);
            await _repositoryManager.SaveChangesAsync();    
        }

        public async Task<IEnumerable<UserDisplayDto>> GetAllUsers()
        {
            var users = await _repositoryManager.UserRepository.GetAllUserAsync(false);
            var usersDto = _mapper.Map<IEnumerable<UserDisplayDto>>(users);
            return usersDto;
        }

        public async Task<UserDisplayDto> GetUserByEmail(string email)
        {
            var user = await _repositoryManager.UserRepository.GetUserByEmailAsync(email, false)
                ?? throw new UserNotFoundException(email);
            var userDto = _mapper.Map<UserDisplayDto>(user);
            return userDto;
        }

        public async Task<UserDisplayDto> GetUserById(Guid id)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(id, false)
                ?? throw new UserNotFoundException(id);
            var userDto = _mapper.Map<UserDisplayDto>(user);
            return userDto;
        }

        public async void UpdateUser(Guid userId, UserUpdateDto userUpdateDto)
        {
            var user = await _repositoryManager.UserRepository.GetUserByIdAsync(userId, false)
                ?? throw new UserNotFoundException(userId);
            var userFromDto = _mapper.Map<User>(userUpdateDto);
            _repositoryManager.UserRepository.UpdateUser(userFromDto);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}
