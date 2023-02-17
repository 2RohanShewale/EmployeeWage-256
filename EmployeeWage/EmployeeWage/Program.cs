using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*_______Employee Wage Program_______*");
            Company company = new Company()
            {
                Name = "Company1",
                WagePerHour= 10,
                WorkingHoursPerMonth= 100,
                NumberOfWorkingDays= 20,

            };
            Company company2 = new Company()
            {
                Name = "Company2",
                WagePerHour = 20,
                WorkingHoursPerMonth = 99,
                NumberOfWorkingDays = 22,

            };
            Employee emp = new Employee();
            emp.EmployeeAttendence(company);
            emp.EmployeeAttendence(company2);

            Console.ReadKey();
        }
    }
}
