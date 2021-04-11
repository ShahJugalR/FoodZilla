using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI.CustomClasses
{
    class VerificationMailSender
    {
        public void SendMail(string _to, int _code)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("developer.dbmsproject@gmail.com");
                mail.To.Add(_to);
                mail.Subject = "Account Verification For FoodZilla";
                mail.Body = "<h2>Welcome To food Zilla! </h2>" +
                    "<h3>Your Verification Code is </h3>" +
                    $"<h1>{_code}</h1>";

                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("developer.dbmsproject@gmail.com", "ShahJugalR.123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("We send you an email with OTP");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
        }
    }
}
