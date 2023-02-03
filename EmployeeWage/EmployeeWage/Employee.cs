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
        const int isPartTime = 2;
        const int present = 1;
        const int WagePerHrs = 20;
        public void EmployeeAttendence()
        {

            int FullDayHrs;
            Random random = new Random();
            int empCheck = random.Next(0,3);

            switch (empCheck)
            {
                case present: Console.WriteLine("Employee is Present"); FullDayHrs = 8; break;
                case isPartTime: Console.WriteLine("Employee is working PartTime"); FullDayHrs = 4; break;
                default:
                    Console.WriteLine("Employee is Absent");
                    FullDayHrs = 0;
                    break;
            }

            Console.WriteLine("Daily Wage : " + FullDayHrs * WagePerHrs);
        }
    }
}
