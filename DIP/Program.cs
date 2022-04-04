using System;
using static DIP.BadMember;
using static DIP.GoodMember;

namespace DIP
{
    class Program
    {
        /*
         * Dependency Inversion Principle: High-level class must not depend upon a lower level class. They must both depend upon abstractions.
         * An abstraction must not depend upon details, but the details must depend upon abstractions.
         * This will ensure the class and ultimately the whole application is very robust and easy to maintain and expand
         */
        static void Main(string[] args)
        {
            //Bad Member Is Calling.....

            var employeeDetails = new EmployeeDetails();
            employeeDetails.InstallmentNumber = 50;
            employeeDetails.InterestRate = 150;
            Console.WriteLine($"The Total Loan is {employeeDetails.GetLoan()}");


            //Good Member Is Calling.....

            var LoanAccountModified = new LoanDetailsModified(new LoanCalculatorImplementor());
            LoanAccountModified.InstallmentNumber = 50;
            LoanAccountModified.InterestRate = 150;
            Console.WriteLine($"The Total Loan is {LoanAccountModified.GetLoan()}");
        }
    }
}
