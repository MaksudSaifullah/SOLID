using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class GoodMember
    {
        /*
         *In the above code, we see that we have created an interface ILoanCalculator and then we have a class called LoanCalculatorImplementor that implements this interface. 
         *Finally, in the higher-level class LoanDetailsModified, we only depend upon the ILoanCalculator interface and not the concrete class. 
         *Hence, when we create the LoanDetailsModified class, we specify the abstraction implementation to use.
         *In addition to this, the details of the CalculatLoan function are hidden from the LoanDetailsModified class and any changes to this function will
         *not affect the interface being used.Hence, we can see that in this new design the higher-level class does not depend upon the lower level class but on an 
         *abstraction and the abstraction does not depend upon the details.To create the LoanDetailsModified class, we use the below code,
         */
        public interface ILoanCalculator
        {
            float CalculatLoan(int installmentNumber, float interestRate);
        }

        public class LoanCalculatorImplementor : ILoanCalculator
        {
            public float CalculatLoan(int installmentNumber, float interestRate) => installmentNumber * interestRate;
        }
        // Higher Level class
        public class LoanDetailsModified
        {
            private readonly ILoanCalculator _loanCalculator;
            public int InstallmentNumber { get; set; }
            public int InterestRate { get; set; }
            public LoanDetailsModified(ILoanCalculator loanCalculator)
            {
                _loanCalculator = loanCalculator;
            }
            public float GetLoan()
            {
                return _loanCalculator.CalculatLoan(InstallmentNumber, InterestRate);
            }
        }
    }
}
