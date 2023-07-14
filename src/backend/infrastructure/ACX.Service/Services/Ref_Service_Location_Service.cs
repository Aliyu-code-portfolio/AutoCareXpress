using ACX.Application.Common;
using ACX.Application.DTOs.Display;
using ACX.Application.Exceptions.SubExceptions;
using ACX.Domain.Model;
using ACX.ServiceContract.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ACX.Service.Services
{
    internal sealed class Ref_Service_Location_Service : IRef_Service_Location_Service
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public Ref_Service_Location_Service(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<Ref_Service_Location_Display_Dto> GerServiceLocationByName(string name)
        {
            var serviceLocation = await _repositoryManager.Ref_Service_Location_Repository.GetServiceLocationByName(name)
                ?? throw new Ref_Service_Location_NotFoundException(name);
            var serviceLocationDto = _mapper.Map<Ref_Service_Location_Display_Dto>(serviceLocation);
            return serviceLocationDto;
        }

        public async Task<IEnumerable<Ref_Service_Location_Display_Dto>> GetAllServiceLocations()
        {
            var serviceLocation = await _repositoryManager.Ref_Service_Location_Repository.GetAllServiceLocation();
            var serviceLocationDto = _mapper.Map<IEnumerable<Ref_Service_Location_Display_Dto>>(serviceLocation);
            return serviceLocationDto;
        }

        public async Task<Ref_Service_Location_Display_Dto> GetServiceLocationById(int id)
        {
            var serviceLocation = await _repositoryManager.Ref_Service_Location_Repository.GetServiceLocationById(id)
                ?? throw new Ref_Service_Location_NotFoundException(id);
            var serviceLocationDto = _mapper.Map<Ref_Service_Location_Display_Dto>(serviceLocation);
            return serviceLocationDto;
        }
    }
}
