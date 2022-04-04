using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class GoodMember
    {
        private sendEmail _sendEmail = new sendEmail();
        private FileLogger _logger = new FileLogger();
        void addDataToDatabase(String _connectionManager)
        {
            try
            {
                //Set of logic for storing data into database
                _sendEmail.sendEmailToMember("Test@123.com");
            }
            catch (Exception ex)
            {
                _logger.HandleLog(ex.ToString());
            }
        }
    }
    class sendEmail
    {
        private FileLogger _logger = new FileLogger();
        internal void sendEmailToMember(string memberEmail)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("email", "password"),
                    EnableSsl = true,
                };

                smtpClient.Send("email", "recipient", "subject", "body");
            }
            catch (Exception ex)
            {
                _logger.HandleLog(ex.ToString());
            }
        }
    }
    class FileLogger
    {
        internal void HandleLog(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error.ToString());
        }
    }
}
