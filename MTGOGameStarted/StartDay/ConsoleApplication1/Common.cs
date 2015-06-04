using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    /* static functions that any class may need */
    public class Common
    {

        public static void SendEmail(string subject, string body)
        {
            MailMessage mail = new MailMessage(Properties.Settings.Default.Email, Properties.Settings.Default.Email);
            SmtpClient client = new SmtpClient();
            client.Port = Int32.Parse(Properties.Settings.Default.Port); // 587
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = Properties.Settings.Default.Host;//"smtp.gmail.com"
            mail.Subject = subject;
            mail.Body = body;
            client.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.Password);
            client.EnableSsl = true;

            client.Send(mail);
        }
    }
}
