using System.Globalization;

namespace Models1
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager ResponsibleManager { get; set; }


        public Contractor(double workHours, int payPerHour, Manager responsibleManager, string firstName, string lastName, double salary = 0) :
            base(firstName, lastName, RoleEnum.Contractor, salary)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            ResponsibleManager = responsibleManager;
        }

        public override double GetSalary()
        {
            double newSalary;
            newSalary = WorkHours * PayPerHour;
            Salary = newSalary;
            return Salary;

        }
        public DepartmentEnum CurrentPosition()
        {
            return ResponsibleManager.Department;
        }

    }
}
