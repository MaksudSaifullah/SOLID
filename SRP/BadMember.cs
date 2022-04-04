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
    /*
     * Author: Maksud Saifullah Pulak
     * Designation: Lead Software Engineer
     * This member class is performing set of activities like 
     * e:g; storing data into the database, incase of any error logging into a text file
     * logging whole transaction details
     * An email will sent to the member email for further acknowledgement.
     */ 
    class BadMember
    {
        void addDataToDatabase(String _connectionManager) 
        {
            try
            {
                //Set of logic for storing data into database
                sendEmailToMember("Test@123.com");
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Error.txt", ex.ToString());
            }
        }

        void sendEmailToMember(string memberEmail)
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
                File.WriteAllText(@"C:\Error.txt", ex.ToString());
            }
        }
    }
}
