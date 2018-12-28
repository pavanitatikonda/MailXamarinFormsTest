using SampleApp1;
using SampleApp1.Droid;
using System;
using System.Net.Mail;
using Xamarin.Forms;

[assembly: Dependency(typeof(DroidMail))]
namespace SampleApp1.Droid
{
    class DroidMail: IMailService
    {
        public DroidMail()
        {

        }
        public void sendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ProjectTest.365@gmail.com");
                mail.To.Add("pavani.tatikonda@ggktech.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                //Credentails of the from mail( login details and password).
                //We Should Turn On the Access for less secure apps in Security folder in "projectTest.365@gmail.com"
                SmtpServer.Credentials = new System.Net.NetworkCredential("ProjectTest.365@gmail.com", "Testaccount123");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

    }
}