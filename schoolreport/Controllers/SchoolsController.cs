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
    [Produces("application/json")]
    [Route("api/Schools")]
    public class SchoolsController:Controller
    {
         private readonly IMapper _mapper;
        private readonly ISchoolRepository _schoolRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SchoolsController(IMapper mapper,ISchoolRepository schoolRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _schoolRepository = schoolRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SaveSchoolResources schoolR)
        {
            // validate model
            if (!ModelState.IsValid)
                return BadRequest();

            // convert from modelresource to datamodel
            var model = _mapper.Map<SaveSchoolResources, School>(schoolR);

            // save into th database
            _schoolRepository.Add(model);

            // save to database
            await _unitOfWork.CompleteAsync();

            // get the saved school
            var school = await _schoolRepository.GetSchool(model.Id);

            // map to resources
            var schoolresources = _mapper.Map<School, SaveSchoolResources>(school);

            return Ok(schoolresources);

        }
        [HttpGet]
        public async Task<IActionResult> GetSchools()
        {
            var school = await _schoolRepository.GetSchools();

            var result =  _mapper.Map<IEnumerable<School>,IEnumerable<SchoolResources>>(school);

            return Ok(result);

        }

        public async Task<IActionResult> GetSchool(int id)
        {
            var school = await _schoolRepository.GetSchool(id);

            var result = _mapper.Map<School, SaveSchoolResources>(school);

            return Ok(result);
        }
    }
}