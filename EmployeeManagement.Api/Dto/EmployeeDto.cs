using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Dto
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public DepartmentDto Department { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
