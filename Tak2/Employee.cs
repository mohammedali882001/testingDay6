using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tak2
{
    internal class Employee
    {
        public Action<float> EmployeeAndCompanyBudet;
        public Employee() { }   
        public string Name {  get; set; }
        public double Salary {  get; set; }
        public int Age { get; set; }

       public void IncreaseSalary(float amount)
        {

            Salary= (float)(Salary + amount);
            EmployeeAndCompanyBudet(amount);
        }
    }
}
