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
        const int TotalWorkingDays = 20;
        public void EmployeeAttendence()
        {

            int TotalHrs = 0;
            Random random = new Random();
            for (int day = 1;  day<= TotalWorkingDays; day++)
            {
                string message = "Day " + day +": ";
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case present: message += "Employee is Present"; TotalHrs += 8; break;
                    case isPartTime: message += "Employee is working PartTime"; TotalHrs += 4; break;
                    default:
                        message += "Employee is Absent";
                        break;
                }
                Console.WriteLine(message);
            }
            Console.WriteLine("Total Wage: " + TotalHrs * WagePerHrs);
            
        }
    }
}
