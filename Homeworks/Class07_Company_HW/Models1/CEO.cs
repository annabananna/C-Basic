using System.Globalization;

namespace Models1
{
    public class CEO : Employee
    {
        public  Employee[] Employees { get; set; }
        public int SharesProperty { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees, int sharesProperty, double sharesPrice) :
            base(firstName, lastName, RoleEnum.CEO, salary)
        {
            Employees = employees;
            SharesProperty = sharesProperty;
            SharesPrice = sharesPrice;
        }

        public double AddSharesPrice(double number)
        {
            SharesPrice = number;
            return SharesPrice;
        }

        public string PrintInfo()
        {
            string info = $"First Name: {FirstName}, Last name: {LastName}, Salary: {GetSalary().ToString("C", new CultureInfo("en-US"))}";
            return info;
        }
        public string PrintEmployees()
        {
            string text = "Employees:\n";
            foreach (Employee employee in Employees)
            {
                text += $"\t {employee.FirstName} {employee.LastName}\n";
            }
            return text;
        }
        public override double GetSalary()
        {
            return Salary + (SharesProperty * SharesPrice);
        }

    }
}
