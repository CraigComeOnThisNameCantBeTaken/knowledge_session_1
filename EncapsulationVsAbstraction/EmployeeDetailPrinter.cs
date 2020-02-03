using System;

namespace EncapsulationVsAbstraction
{
    class EmployeeDetailPrinter
    {
        public Employee Employee { get; }
        public EmployeeDetailPrinter(Employee employee)
        {
            Employee = employee;
        }

        public void PrintIncomeToDate()
        {
            Console.WriteLine(Employee.Salary * Employee.YearsWorked);
        }
    }
}
