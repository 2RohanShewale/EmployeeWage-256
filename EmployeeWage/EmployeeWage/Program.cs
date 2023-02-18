using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           EmployeeWagebuiderObject empWageBuilder = new EmployeeWagebuiderObject();
            empWageBuilder.AddCompanyEmpWage("KMart", 20, 2,10);
            empWageBuilder.AddCompanyEmpWage("SmallBasket", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();

            Console.ReadKey();
        }
    }
}