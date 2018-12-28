using System;
using System.Net.Mail;
using SampleApp1.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(IosMail))]
namespace SampleApp1.iOS
{
    class IosMail : IMailService
    {
        public void sendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add("to_address");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        }
    }
}