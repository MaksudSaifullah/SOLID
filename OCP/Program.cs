using System;
using System.Collections.Generic;
using static OCP.BadMember;
//using static OCP.GoodMember;

namespace OCP
{
    class Program
    {
        /*
         * Open Close Principle: Open for extension closed for modification.
         * Prefer extension over modification.
         */
        static void Main(string[] args)
        {

            // Bed Member Calling

            var loanAmounts = new List<GetLoanQuatotaion>()
            {
                new GetLoanQuatotaion {LoanId=001, LoanCategory = "Basic",ProductName= "LoanProduct1", PrincipleAmount= 10, InterestRate= 1, Tenure =10 },
                new GetLoanQuatotaion {LoanId=002,LoanCategory = "Gold", ProductName= "LoanProduct2", PrincipleAmount= 20, InterestRate= 1, Tenure =10 },
                new GetLoanQuatotaion {LoanId=003, LoanCategory = "Basic",ProductName= "LoanProduct3", PrincipleAmount= 30, InterestRate= 1, Tenure =10 }
            };
            var loanAmount = new LoanCalculator(loanAmounts);
            Console.WriteLine($"Sum of all the loan disbursed amount is {loanAmount.CalculateTotalLoanAmount()} dollars");



            // Good Member Calling

            //var loanAmounts = new List<BaseLoanCalculator>()
            //{
            //    new BasicLoanCalculation(new GoodMember.GetLoanQuatotaion {LoanId=001, LoanCategory = "Basic",ProductName= "LoanProduct1", PrincipleAmount= 10, InterestRate= 1, Tenure =10 }),
            //    new GoldLoanCalculation (new GoodMember.GetLoanQuatotaion{LoanId=002,LoanCategory = "Gold", ProductName= "LoanProduct2", PrincipleAmount= 20, InterestRate= 1, Tenure =10 }),
            //    new BasicLoanCalculation (new GoodMember.GetLoanQuatotaion{LoanId=003, LoanCategory = "Basic",ProductName= "LoanProduct3", PrincipleAmount= 30, InterestRate= 1, Tenure =10 })


            //};
            //var loanAmount = new GoodMember.LoanCalculation(loanAmounts);
            //Console.WriteLine($"Sum of all the loan disbursed amount is {loanAmount.CalculateTotalLoanAmounts()} dollars");

        }
    }
}
