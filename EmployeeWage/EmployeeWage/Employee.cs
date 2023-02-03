using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EmployeeWage
{
    public class Employee
    {
        const int present = 1;
        const int WagePerHrs = 20;
        public void EmployeeAttendence()
        {

            int FullDayHrs;
            Random random = new Random();
            int empCheck = random.Next(0,2);

            if (empCheck == present)
            {
                Console.WriteLine("Employee is Present");
                FullDayHrs = 8;
            }
            else
            {
                FullDayHrs = 0;
                Console.WriteLine("Employee is not Absent");
            }

            Console.WriteLine("Daily Wage : " + FullDayHrs * WagePerHrs);
        }
    }
}
