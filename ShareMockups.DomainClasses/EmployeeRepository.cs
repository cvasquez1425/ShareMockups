using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareMockups.DomainClasses
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        List<Employee> _employees = new List<Employee>()
        {
            new Employee { ID = 1, Name = "Poonam",    DepartmentID = 1 },
            new Employee { ID = 2, Name = "Marcus",    DepartmentID = 2 },
            new Employee { ID = 3, Name = "Denn",      DepartmentID   = 1 },
            new Employee { ID = 4, Name = "John Papa", DepartmentID = 3 },
            new Employee { ID = 5, Name = "Carl",      DepartmentID = 2 }
        };

    }
}
