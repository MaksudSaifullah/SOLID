using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class GoodMember
    {
        public interface ICreateLoanAccountSaving
        {
            void CreateNomineeInformation(string NomeeInfo);
            void CheckNomineeInfo(string NomInfo);
        }
        public interface ICreateLoanAccountDisburse
        {
            void CheckGrantorInfo(string GranInfo);
            void CreateGrantorInformation(string GranInfo);
        }
        public interface MultiInterface : ICreateLoanAccountSaving
        {
            void CheckGrantorInfo2(string GranInfo);
        }

        public class CreateSavingAccount : ICreateLoanAccountSaving
        {
            public void CreateNomineeInformation(string GranInfo)
            {
                //Implementation Of Nominee Info
            }
            public void CheckNomineeInfo(string GranInfo)
            {
                //Implementation Of Nominee Info
            }
        }
        public class CreateLoanAccount : ICreateLoanAccountDisburse
        {
            public void CheckGrantorInfo(string GranInfo)
            {
                //Implementation Of Nominee Info
            }
            public void CreateGrantorInformation(string GranInfo)
            {
                //Implementation Of Nominee Info
            }
        }
        public class CheckMemberAccount : ICreateLoanAccountSaving, ICreateLoanAccountDisburse
        {
            public void CreateGrantorInformation(string GranInfo)
            {
                //Implementation Of Grantor Info
            }
            public void CreateNomineeInformation(string GranInfo)
            {
                //Implementation Of Nominee Info
            }
            public void CheckGrantorInfo(string GranInfo)
            {
                //Implementation Of Grantor Info
            }
            public void CheckNomineeInfo(string GranInfo)
            {
                //Implementation Of Nominee Info
            }
            public void CreateGrantorInformation2(string GranInfo)
            {
                //Implementation Of Grantor Info
            }
            public void CheckGrantorInfo2(string GranInfo)
            {
                //Implementation Of Grantor Info
            }
        }
    }
}
