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
            EmployeeWagebuiderObject kMart = new EmployeeWagebuiderObject("KMart", 20, 2,10);
            EmployeeWagebuiderObject samllBasket = new EmployeeWagebuiderObject("Small Basket", 10, 4, 20);
            kMart.ComputeEmpWage();
            Console.WriteLine(kMart.toString());
            samllBasket.ComputeEmpWage();
            Console.WriteLine(samllBasket.toString());

            Console.ReadKey();
        }
    }
}
