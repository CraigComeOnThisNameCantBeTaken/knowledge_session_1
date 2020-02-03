using System;

namespace EncapsulationVsAbstraction
{
    class Program
    {
        // BAD ENCAPSULATION EXAMPLE
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                YearsWorked = 8,
                Salary = 50000
            };

            var printer = new EmployeeDetailPrinter(employee);
            printer.PrintIncomeToDate();

            // this was find but now the implementation details of the Employee ae going to change
            // so change years worked to Months worked while Salary is still yearly. Now our client code will break.
        }
    }
}
