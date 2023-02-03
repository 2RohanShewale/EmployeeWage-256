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
            Employee emp = new Employee();
            emp.EmployeeAttendence();

            Console.ReadKey();
        }
    }
}
