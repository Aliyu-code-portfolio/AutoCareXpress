using ACX.Application.Common;
using ACX.Application.DTOs.Display;
using ACX.Application.Exceptions.SubExceptions;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Service.Services
{
    internal sealed class Ref_Service_Type_Service : IRef_Service_Type_Service
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public Ref_Service_Type_Service(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Ref_Service_Type_Display_Dto>> GetAllServiceTypes()
        {
            var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetAllServiceType();
            var serviceTypesDto = _mapper.Map<IEnumerable<Ref_Service_Type_Display_Dto>>(serviceType);
            return serviceTypesDto;
        }

        public async Task<Ref_Service_Type_Display_Dto> GetServiceTypeById(int id)
        {
            var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetServiceTypeById(id)
                ?? throw new Ref_Service_Type_NotFoundException(id);
            var serviceTypesDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
            return serviceTypesDto;
        }

        public async Task<Ref_Service_Type_Display_Dto> GetServiceTypeByName(string name)
        {
            var serviceType = await _repositoryManager.Ref_Service_Type_Repository.GetServiceTypeByName(name)
                ?? throw new Ref_Service_Type_NotFoundException(name);
            var serviceTypesDto = _mapper.Map<Ref_Service_Type_Display_Dto>(serviceType);
            return serviceTypesDto;
        }
    }
}
