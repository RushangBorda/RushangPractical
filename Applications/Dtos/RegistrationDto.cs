using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Dtos
{
    public class RegistrationDto
    {
        public int Id { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public int Salary { get; set; }
        public DateTime Dob { get; set; }
    }
}
