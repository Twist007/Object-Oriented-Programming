using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy
{
    class Manager : Employee
    {
        private List<Employee> employees; 

        public Manager(uint id, string firstName, string lastName, decimal salary, DepartmanType departman) 
            : base(id, firstName, lastName, salary, departman)
        {
            this.Employees=new List<Employee>();
        }

        public IEnumerable<Employee> Employees { get; }

        public void AddEmployee(Employee employee)
        {
            if (employee.DepartmanType!=this.DepartmanType)
            {
                throw new ArgumentException("Deartmant of employee and manager must be the same.");
            }
            this.employees.Add(employee);
        }
    }
}
