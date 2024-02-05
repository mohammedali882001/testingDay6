using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tak2
{
    internal class Company
    {
        public Company() { }
        public string Name { get; set; }
        public double Budget { get; set; }
        public List<Employee> Employees = new List<Employee>();

        
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            employee.EmployeeAndCompanyBudet += decreaseBudget;
        }
        public void decreaseBudget(float amount)
        {
            this.Budget -= amount;
        }

       public List<Employee> FilterEmployees(Func<Employee,bool>filter)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee emp in Employees)
            {
                if(filter(emp))
                {
                    result.Add(emp);
                   
                }

                if(emp.Salary>5000)
                    result.Add(emp);
              
            }
            return result;
        }
    }
}
