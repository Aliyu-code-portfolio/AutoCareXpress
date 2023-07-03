using ACX.Application.Common;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
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
        public async void DeletePickUpAddress(Guid id)
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

        public async void UpdatePickUpAddress(PickUpAddressUpdateDto pickUpAddressUpdateDto)
        {
            var address = await _repositoryManager.PickUpAddress_Repository.GetPickUpAddressByUserId(pickUpAddressUpdateDto.UserId, false)
               ?? throw new PickUpAddressNotFoundException(pickUpAddressUpdateDto.UserId);
            var addressFromDto = _mapper.Map<PickUpAddress>(pickUpAddressUpdateDto);
            _repositoryManager.PickUpAddress_Repository.UpdatePickUpAddress(addressFromDto);
            await _repositoryManager.SaveChangesAsync();
        }
    }
}
