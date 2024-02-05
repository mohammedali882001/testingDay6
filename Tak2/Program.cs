namespace Tak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company() {Budget=500000,Name="Egada" };
            Employee employee1 = new Employee() {Name = "leo" , Age=22, Salary=3000};
            Employee employee2 = new Employee() { Name = "messi", Age = 22, Salary = 3500 };
            Employee employee3 = new Employee() { Name = "ali", Age = 22, Salary = 2500 };
            Employee employee4 = new Employee() { Name = "ahmed", Age = 22, Salary = 10000 };

            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            company.AddEmployee(employee3);
            company.AddEmployee(employee4);

            Console.WriteLine(company.Budget);
            employee3.IncreaseSalary(500000);
            Console.WriteLine(company.Budget);
            Console.WriteLine(employee3.Salary);

            Func<Employee, bool> filter = emp => emp.Salary > 3000;
            List<Employee>newList = company.FilterEmployees(filter);
            foreach(Employee emp in newList)
            {
                Console.WriteLine(emp.Name);
            }





        }
    }
}
