using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Model
{
    public class Registration
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
