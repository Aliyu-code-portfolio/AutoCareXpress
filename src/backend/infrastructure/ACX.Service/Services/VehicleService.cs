using ACX.Application.Common;
using ACX.Application.DTOs.Creation;
using ACX.Application.DTOs.Display;
using ACX.Application.DTOs.Update;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Services
{
    internal sealed class VehicleService : IVehicleService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public VehicleService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<VehicleDisplayDto> CreateVehicle(VehicleCreationDto vehicleCreationDto)
        {
            var vehicle = _mapper.Map<Vehicle>(vehicleCreationDto);
            _repositoryManager.Vehicle_Repository.CreateVehicle(vehicle);
            await _repositoryManager.SaveChangesAsync();
            var vehicleDto = _mapper.Map<VehicleDisplayDto>(vehicle);
            return vehicleDto;
        }

        public async void DeleteVehicle(int id)
        {
            var vehicle = await _repositoryManager.Vehicle_Repository.GetVehicleById(id, false)
                ?? throw new VehicleNotFoundException(id);
            _repositoryManager.Vehicle_Repository.DeleteVehicle(vehicle);
            await _repositoryManager.SaveChangesAsync();
        }

        public async Task<IEnumerable<VehicleDisplayDto>> GetAllUserVehicles(Guid userId, bool trackChanges)
        {
            var vehicles = await _repositoryManager.Vehicle_Repository.GetAllUserVehicle(userId, false);
            var vehiclesDto = _mapper.Map<IEnumerable<VehicleDisplayDto>>(vehicles);
            return vehiclesDto;
        }

        public async Task<IEnumerable<VehicleDisplayDto>> GetAllVehicles(bool trackChanges)
        {
            var vehicles = await _repositoryManager.Vehicle_Repository.GetAllVehicle(false);
            var vehiclesDto = _mapper.Map<IEnumerable<VehicleDisplayDto>>(vehicles);
            return vehiclesDto;
        }

        public async Task<VehicleDisplayDto> GetVehicleById(int id)
        {
            var vehicle = await _repositoryManager.Vehicle_Repository.GetVehicleById(id, false)
                ??throw new VehicleNotFoundException(id);
            var vehicleDto = _mapper.Map<VehicleDisplayDto>(vehicle);
            return vehicleDto;
        }

        public async void UpdateVehicle(VehicleUpdateDto vehicleUpdateDto)
        {
            var vehicle = await _repositoryManager.Vehicle_Repository.GetVehicleById(vehicleUpdateDto.Id, false)
                ?? throw new VehicleNotFoundException(vehicleUpdateDto.Id);
            var vehicleFromDto = _mapper.Map<Vehicle>(vehicleUpdateDto);
            _repositoryManager.Vehicle_Repository.UpdateVehicle(vehicleFromDto);
            await _repositoryManager.SaveChangesAsync();    

        }
    }
}
