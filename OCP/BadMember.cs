using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class BadMember
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
        public class LoanCalculator
        {
            private readonly IEnumerable<GetLoanQuatotaion> _getLoanQuatotaions;

            public LoanCalculator(List<GetLoanQuatotaion> getLoanQuatotaion)
            {
                _getLoanQuatotaions = getLoanQuatotaion;
            }

            public double CalculateTotalLoanAmount()
            {
                double totalLoanAmounts = 0D;
                foreach (var loanAmount in _getLoanQuatotaions)
                {
                    if (loanAmount.LoanCategory == "Basic")
                        totalLoanAmounts += loanAmount.PrincipleAmount * loanAmount.InterestRate * loanAmount.Tenure - 100;
                    else
                        totalLoanAmounts += loanAmount.PrincipleAmount * loanAmount.InterestRate * loanAmount.Tenure - 200;
                }
                return totalLoanAmounts;
            }

        }
    }
}
