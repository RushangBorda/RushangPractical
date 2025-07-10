using Applications.Dtos;
using Applications.IServices;
using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace RushangPractical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly EmployeeContext _employeeContext;
        private readonly IRegistrationService _registrationService;
        public RegistrationController(EmployeeContext employeeContext, IRegistrationService registrationService)
        {
            _employeeContext = employeeContext;
            _registrationService = registrationService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var registrations = await _registrationService.GetAllRegistration();
            return Ok(registrations);
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var registration = await _registrationService.GetRegistrationById(id);
            if (registration == null)
            {
                return NotFound();
            }
            return Ok(registration);
        }
        [HttpPost]
        public async Task<IActionResult> addRegistration([FromBody] RegistrationDto dto)
        {
            var registration = await _registrationService.addRegistrationDto(dto);
            if (registration == null)
            {
                return NotFound();
            }
            return Ok(registration);
        }
        [HttpPut]
        public async Task<IActionResult> updateRegistration([FromBody] RegistrationDto dto)
        {
            var registration = await _registrationService.updateRegistrationDto(dto);
            if (registration == null)
            {
                return NotFound();
            }
            return Ok(registration);
        }
        [HttpDelete]
        public async Task<IActionResult> deleteRegistrationDto(int id)
        {
            var registration = await _registrationService.deleteRegistrationDto(id);
            if (registration == null)
            {
                return NotFound();
            }
            return Ok(registration);
        }
    }
}
