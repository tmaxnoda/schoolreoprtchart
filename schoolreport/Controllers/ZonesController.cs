using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using schoolreport.Controllers.Resources;
using schoolreport.Core.IRepositories;
using schoolreport.Core.IUnitOfWorks;
using schoolreport.Models;

namespace schoolreport.Controllers
{
    public class ZonesController:Controller
    {
         private readonly IUnitOfWork _unitOfwork;
        private readonly IZoneRepository _repository;
        private readonly IMapper _mapper;

        public ZonesController(IUnitOfWork unitOfwork, IZoneRepository repository,IMapper mapper)
        {
            _unitOfwork = unitOfwork;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetZones()
        {
            var zones = await _repository.GetZones();
            var result = _mapper.Map<IEnumerable<Zone>, IEnumerable<SaveZoneResources>>(zones);

            return Ok(result);

        }
    }
}