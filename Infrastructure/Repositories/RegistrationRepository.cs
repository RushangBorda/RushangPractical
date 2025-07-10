using Infrastructure.Context;
using Infrastructure.IRepositories;
using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly EmployeeContext _employeeContext;
        //private readonly IMapper _mapper;

        public RegistrationRepository(EmployeeContext employeeContext/*, IMapper mapper*/)
        {
            _employeeContext = employeeContext;
            //_mapper = mapper;
        }

        public async Task<Registration?> Create(Registration data)
        {
            await _employeeContext.Registration.AddAsync(data);
            await _employeeContext.SaveChangesAsync();
            return data;
        }

        public async Task<Registration?> Delete(int id)
        {
            var regObj = await _employeeContext.Registration.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (regObj != null)
            {
                _employeeContext.Registration.Remove(regObj);
            }
            await _employeeContext.SaveChangesAsync();
            return regObj;
        }

        public async Task<List<Registration>> GetAllAsync()
        {
            return await _employeeContext.Registration.ToListAsync();
        }

        public async Task<Registration?> GetRegistrationById(int id)
        {
            return await _employeeContext.Registration.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Registration?> Update(Registration dataObj)
        {
            var regObj = await _employeeContext.Registration.Where(x => x.Id == dataObj.Id).FirstOrDefaultAsync();
            if (regObj != null)
            {
                regObj.Salutation = dataObj.Salutation;
                regObj.Name = dataObj.Name;
                regObj.Phone = dataObj.Phone;
                regObj.Salary = dataObj.Salary;
                regObj.Dob = dataObj.Dob;
                regObj.Email = dataObj.Email;
                regObj.DepartmentId = dataObj.DepartmentId;
            }
            await _employeeContext.SaveChangesAsync();
            return regObj;
        }
    }
}
