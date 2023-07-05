using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Application.Exceptions;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Services
{
    internal sealed class PickUpAddressService : IPickUpAddressService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public PickUpAddressService(IRepositoryManager repositoryManager,IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<PickUpAddressDisplayDto> CreateUserPickUpAddress(PickUpAddressCreationDto pickUpAddressCreationDto)
        {
            var addressFromDB = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(pickUpAddressCreationDto.UserId,false);
            if (addressFromDB is not null)
            {
                throw new CannotCreateException("The item already exists or something went wrong");
            }
            var address = _mapper.Map<PickUpAddress>(pickUpAddressCreationDto);
            _repositoryManager.PickUpAddress_Repository.CreatePickUpAddress(address);
            await _repositoryManager.SaveChangesAsync();
            var addressDto = _mapper.Map<PickUpAddressDisplayDto>(address);
            return addressDto;
        }

        public async Task DeletePickUpAddress(Guid id)
        {
            var address = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(id, false)
                ?? throw new PickUpAddressNotFoundException(id);
            _repositoryManager.PickUpAddress_Repository.DeletePickUpAddress(address);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<PickUpAddressDisplayDto> GetUserPickUpAddress(Guid userId, bool trackChanges)
        {
            var address = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(userId, false)
               ?? throw new PickUpAddressNotFoundException(userId);
            var addressDto = _mapper.Map<PickUpAddressDisplayDto>(address);
            return addressDto;
        }

        public async Task UpdatePickUpAddress(PickUpAddressUpdateDto pickUpAddressUpdateDto)
        {
            var address = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(pickUpAddressUpdateDto.UserId, false)
               ?? throw new PickUpAddressNotFoundException(pickUpAddressUpdateDto.UserId);
            var addressFromDto = _mapper.Map<PickUpAddress>(pickUpAddressUpdateDto);
            _repositoryManager.PickUpAddress_Repository.UpdatePickUpAddress(addressFromDto);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}
