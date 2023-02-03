using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        const int present = 1;
        public void EmployeeAttendence()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0,2);

            if (empCheck == present)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is not Absent");
        }
    }
}
