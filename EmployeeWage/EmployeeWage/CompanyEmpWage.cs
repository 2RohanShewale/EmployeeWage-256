﻿using System.Collections.Generic;

namespace EmployeeWage
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public Dictionary<string,int> dailyWage;//UC13
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            dailyWage= new Dictionary<string,int>();//UC13
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public void SetDailyEmpWage(string day,int dailyEmpWage)
        {
            dailyWage.Add(day, dailyEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage For company: " + company + " is: " + totalEmpWage;
        }
    }
}
