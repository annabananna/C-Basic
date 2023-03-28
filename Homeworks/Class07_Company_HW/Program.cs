using System.Globalization;
using System.Reflection;
using System.Security.Principal;
using Models1;

namespace Class07_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, to our company!");

            SalesPerson salesPerson1 = new SalesPerson("Sales", "One");
            SalesPerson salesPerson2 = new SalesPerson("Sales", "Two");

            Manager manager = new Manager("Manager", "Manager", 1500, DepartmentEnum.Marketing);

            salesPerson1.AddSuccessRevenue(300);
            salesPerson2.AddSuccessRevenue(500);

            salesPerson2.AddSuccessRevenue(300);
            salesPerson1.AddSuccessRevenue(2000);

            manager.AddBonus(450);

            Console.WriteLine(salesPerson1.GetInfo());
            Console.WriteLine(salesPerson2.GetInfo());
            Console.WriteLine(manager.GetInfo());

            Employee otherEmployee = new Employee("Risto", "Panchevski", RoleEnum.Other, 300);

            Console.WriteLine(otherEmployee.GetInfo());

            Manager manager1 = new Manager("John", "Doe", 2000, DepartmentEnum.ProjectManagement);
            Manager manager2 = new Manager("Bob", "Bobski", 1800, DepartmentEnum.Coding);

            Contractor contractor1 = new Contractor(8.5, 7, manager1, "Jul", "Julski");
            Console.WriteLine($"{contractor1.FirstName} {contractor1.LastName} has {manager1.FirstName} {manager1.LastName} as a manager which is responsible also for {contractor1.CurrentPosition()}");
            Console.WriteLine($"{contractor1.GetSalary().ToString("C", new CultureInfo("en-US"))}");

            Contractor contractor2 = new Contractor(12, 10, manager2, "Tom", "Tomski");
            Console.WriteLine($"{contractor2.FirstName} {contractor2.LastName} has {manager2.FirstName} {manager2.LastName} as a manager which is responsible also for {contractor2.CurrentPosition()}");
            Console.WriteLine($"{contractor2.GetSalary().ToString("C", new CultureInfo("en-US"))}");

            Employee[] company = new Employee[5];
            company[0] = contractor1;
            company[1] = contractor2;
            company[2] = manager1;
            company[3] = manager2;
            company[4] = salesPerson1;

            CEO ceo1 = new CEO("Ron", "Ronski", 1500, company, 3, 200);

            Console.WriteLine(ceo1.PrintInfo());
            Console.WriteLine($"Salary of CEO is: {ceo1.GetSalary().ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine(ceo1.PrintEmployees());

        }
    }
}