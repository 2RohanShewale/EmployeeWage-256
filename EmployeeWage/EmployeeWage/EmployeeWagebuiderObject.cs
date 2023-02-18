﻿using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    public class EmployeeWagebuiderObject : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private List<CompanyEmpWage> companyEmpWageList;

        public EmployeeWagebuiderObject()
        {
            this.companyEmpWageList = new List<CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage company1 = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.Add(company1);
        }
        public void ComputeEmpWage()
        {
            foreach (var companyEmpWage in companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
        }
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            Random random = new Random();
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                companyEmpWage.SetDailyEmpWage($"{totalWorkingDays}",(empHrs*companyEmpWage.empRatePerHour));
                Console.WriteLine("Day#" + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }

}
