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
        public void EmployeeAttendence(Company company)
        {
            Console.WriteLine(company.Name);
            int totalHours = 0, day = 1;
            Random random = new Random();
            while (day <= company.NumberOfWorkingDays && totalHours <= company.WorkingHoursPerMonth)
            {
                string message = "Day " + day +": ";
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case present: message += "Employee is Present"; totalHours += 8; break;
                    case isPartTime: message += "Employee is working PartTime"; totalHours += 4; break;
                    default:
                        message += "Employee is Absent";
                        break;
                }
                Console.WriteLine(message);
                day++;
            }
            Console.WriteLine("Total Wage: " + totalHours * company.WagePerHour);
            
        }
    }
}
