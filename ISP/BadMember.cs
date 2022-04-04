using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class BadMember
    {
        public interface ICreateLoanAccount 
        {
            void CreateGrantorInformation(string GranInfo);
            void CreateNomineeInformation(string NomeeInfo);
            void CheckGrantorInfo(string GranInfo);
            void CheckNomineeInfo(string NomInfo);
        }

        public class CreateSavingAccount : ICreateLoanAccount
        {
            public void CreateGrantorInformation(string GranInfo)
            {
                //Implementation Of Grantor Info
                Console.WriteLine("Create grantor information.....");
            }
            public void CreateNomineeInformation(string GranInfo)
            {
                //Implementation Of Nominee Info
                Console.WriteLine("Create nominee information.....");
            }
            public void CheckGrantorInfo(string GranInfo)
            {
                //Implementation Of Grantor Info
                Console.WriteLine("Check Grantor information.....");
            }
            public void CheckNomineeInfo(string GranInfo)
            {
                //Implementation Of Nominee Info
                Console.WriteLine("Check Nominee information.....");
            }
        }
        public class CreateGrantorAccount : ICreateLoanAccount
        {
            public void CreateGrantorInformation(string GranInfo)
            {
                //Implementation Of Grantor Info
                Console.WriteLine("Create grantor information.....");
            }
            public void CreateNomineeInformation(string GranInfo)
            {
                //Implementation Of Nominee Info
                Console.WriteLine("Create nominee information.....");
            }
            public void CheckGrantorInfo(string GranInfo)
            {
                //Implementation Of Grantor Info
                Console.WriteLine("Check Grantor information.....");
            }
            public void CheckNomineeInfo(string GranInfo)
            {
                //Implementation Of Nominee Info
                Console.WriteLine("Check Nominee information.....");
            }
        }
    }
}
