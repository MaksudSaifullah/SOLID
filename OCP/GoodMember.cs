using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OCP
{
    internal class GoodMember
    {
        /*
         * Author: Maksud Saifullah Pulak
         * Designation: Lead Software Engineer
         * This member class is performing set of activities like 
         * e:g; calculate loan quatotation based on users loan category
         */
        public class GetLoanQuatotaion
        {
            public int LoanId { get; set; }
            public string LoanCategory { get; set; }
            public string ProductName { get; set; }
            public double PrincipleAmount { get; set; }
            public double InterestRate { get; set; }
            public int Tenure { get; set; }
        }
        public abstract class BaseLoanCalculator
        {
            protected GetLoanQuatotaion GetLoanQuatotaion { get; private set; }

            public BaseLoanCalculator(GetLoanQuatotaion getLoanQuatotaion)
            {
                GetLoanQuatotaion = getLoanQuatotaion;
            }
            public abstract double CalculateLoanAmount();
        }

        public class BasicLoanCalculation : BaseLoanCalculator
        {
            public BasicLoanCalculation(GetLoanQuatotaion loanCal) : base(loanCal) { }
            public override double CalculateLoanAmount() => GetLoanQuatotaion.PrincipleAmount * GetLoanQuatotaion.InterestRate * GetLoanQuatotaion.Tenure - 100;
        }

        public class GoldLoanCalculation : BaseLoanCalculator
        {
            public GoldLoanCalculation(GetLoanQuatotaion loanCalculator) : base(loanCalculator) { }
            public override double CalculateLoanAmount() => GetLoanQuatotaion.PrincipleAmount * GetLoanQuatotaion.InterestRate * GetLoanQuatotaion.Tenure - 200;
        }

        public class LoanCalculation 
        {
            //Here we have used readonly keyword in order to assign value at the constructor only
            // as readonly keyword The readonly keyword can be used to define a variable or an object
            // as readable only. This means that the variable or object can be assigned a value at the
            // class scope or in a constructor only. We can not change the value or reassign a value.

            private readonly IEnumerable<BaseLoanCalculator> _loanCalculation;
            //Here we have used IEnumerable as we wanted to Iterate among our classes using a foreach loop.
            //This can be done through ICollection/Ilist as well.
            public LoanCalculation(IEnumerable<BaseLoanCalculator> loanCalculation)
            {
                _loanCalculation = loanCalculation;
            }

            public double CalculateTotalLoanAmounts()
            {
                double totalLoanAmounts = 0D;

                foreach (var loanCal in _loanCalculation)
                {
                    totalLoanAmounts += loanCal.CalculateLoanAmount();
                }
                return totalLoanAmounts;
            }
        }

    }
}
