using ACX.Application.Common;
using ACX.Application.DTOs.Display;
using ACX.Application.Exceptions;
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
    internal sealed class DoYouKnowService : IDoYouKnowService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public DoYouKnowService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<IEnumerable<DoYouKnowDisplayDto>> GetAllDoYouKnow()
        {
            var doYouKnows = await _repositoryManager.DoYouKnowRepository.GetAllDoYouKnow();
            var doYouKnowDtos = _mapper.Map<IEnumerable<DoYouKnowDisplayDto>>(doYouKnows);
            return doYouKnowDtos;
        }

        public async Task<DoYouKnowDisplayDto> GetLatestDoYouKnow()
        {
            var doYouKnow = await _repositoryManager.DoYouKnowRepository.GetLatestDoYouKnow()
                ?? throw new NotFoundException("No latest DoYouKnow article");
            var doYouKnowDto = _mapper.Map<DoYouKnowDisplayDto>(doYouKnow);
            return doYouKnowDto;

        }

        public async Task<DoYouKnowDisplayDto> GetRandomDoYouKnow()
        {
            var doYouKnow = await _repositoryManager.DoYouKnowRepository.GetRandomDoYouKnow()
                ?? throw new NotFoundException("No latest DoYouKnow article");
            var doYouKnowDto = _mapper.Map<DoYouKnowDisplayDto>(doYouKnow);
            return doYouKnowDto;
        }
    }
}
