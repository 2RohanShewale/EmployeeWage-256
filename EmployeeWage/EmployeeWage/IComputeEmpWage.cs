namespace EmployeeWage
{
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeEmpWage();
        int ComputeEmpWage(CompanyEmpWage companyEmpWage);
    }
}
