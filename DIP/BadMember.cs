using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class BadMember
    {
        public class LoanCalculator
        {
            public float CalculateLoan(int InstallmentNumber, float InterestRate) => InstallmentNumber * InterestRate;
        }
        //These classes do not follow the “Dependency Inversion Principle” as the higher-level class EmployeeDetails is directly depending upon the lower level SalaryCalculator class
        public class EmployeeDetails
        {
            public int InstallmentNumber { get; set; }
            public int InterestRate { get; set; }
            public float GetLoan()
            {
                var loanCalculator = new LoanCalculator();
                return loanCalculator.CalculateLoan(InstallmentNumber, InterestRate);
            }
        }
    }
}
