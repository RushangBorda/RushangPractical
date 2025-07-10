using Applications.Dtos;
using Applications.IServices;
using Infrastructure.Context;
using Infrastructure.IRepositories;
using Infrastructure.Model;
using Infrastructure.Repositories;

namespace Applications.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository registrationRepository;
        private readonly EmployeeContext employeeContext;
        //private readonly IMapper _mapper;

        public RegistrationService(IRegistrationRepository registrationRepository, EmployeeContext employeeContext/*, IMapper mapper*/)
        {
            this.registrationRepository = registrationRepository;
            this.employeeContext = employeeContext;
            //_mapper = mapper;
        }
        public async Task<List<RegistrationDto>> GetAllRegistration()
        {
            var registrations = await registrationRepository.GetAllAsync();
            var registrationDto = new List<RegistrationDto>();
            foreach (var registration in registrations)
            {
                registrationDto.Add(new RegistrationDto()
                {
                    DepartmentId = registration.DepartmentId,
                    Email = registration.Email,
                    Id = registration.Id,
                    Name = registration.Name,
                    Phone = registration.Phone,
                    Salary = registration.Salary,
                    Salutation = registration.Salutation,
                    Dob = registration.Dob,
                });
            }
            //var registrationDto = _mapper.Map<List<RegistrationDto>>(registrations);
            return registrationDto;
        }

        public async Task<RegistrationDto> GetRegistrationById(int id)
        {
            var registrations = await registrationRepository.GetRegistrationById(id);
            RegistrationDto registrationDto = new RegistrationDto();

            registrationDto.DepartmentId = registrations.DepartmentId;
            registrationDto.Email = registrations.Email;
            registrationDto.Id = registrations.Id;
            registrationDto.Name = registrations.Name;
            registrationDto.Phone = registrations.Phone;
            registrationDto.Salary = registrations.Salary;
            registrationDto.Salutation = registrations.Salutation;
            registrationDto.Dob = registrations.Dob;

            //return _mapper.Map<RegistrationDto>(registrations);
            return registrationDto;
        }

        public async Task<RegistrationDto> addRegistrationDto(RegistrationDto dto)
        {
            var registraton = new Registration();
            registraton.Salutation = dto.Salutation;
            registraton.Name = dto.Name;
            registraton.Phone = dto.Phone;
            registraton.Salary = dto.Salary;
            registraton.Dob = dto.Dob;
            registraton.Email = dto.Email;
            registraton.DepartmentId = dto.DepartmentId;

            //var registraton = _mapper.Map<Registration>(dto);
            await registrationRepository.Create(registraton);
            return (dto);
        }
        public async Task<RegistrationDto> updateRegistrationDto(RegistrationDto dto)
        {
            //var obj = _mapper.Map<Registration>(dto);
            //await registrationRepository.Update(obj);
            return (dto);
        }

        public async Task<RegistrationDto> deleteRegistrationDto(int id)
        {
            var regObj = await registrationRepository.Delete(id);
            var dto = new RegistrationDto();
            if (regObj != null)
            {
                dto.Id = regObj.Id;
                dto.DepartmentId = regObj.DepartmentId;
                dto.Salutation = regObj.Salutation;
                dto.Name = regObj.Name;
                dto.Phone = regObj.Phone;
                dto.Salary = regObj.Salary;
                dto.Dob = regObj.Dob;
                dto.Email = regObj.Email;
            }
            //var dto = _mapper.Map<RegistrationDto>(regObj);
            return (dto);
        }
    }
}
