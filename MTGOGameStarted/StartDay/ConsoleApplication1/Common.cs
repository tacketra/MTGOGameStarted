using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MtgoGame
{

    /* static functions that any class may need */
    public class Common
    {

        public static void SendEmail(string subject, string body)
        {
            // change below back if doesn't work, testing phone number sending
            MailMessage mail = new MailMessage(ConsoleApplication1.Properties.Settings.Default.Email, ConsoleApplication1.Properties.Settings.Default.EmailTo);
            SmtpClient client = new SmtpClient();
            client.Port = Int32.Parse(ConsoleApplication1.Properties.Settings.Default.Port); // 587
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = ConsoleApplication1.Properties.Settings.Default.Host;//"smtp.gmail.com"
            mail.Subject = subject;
            mail.Body = body;
            client.Credentials = new System.Net.NetworkCredential(ConsoleApplication1.Properties.Settings.Default.Email, ConsoleApplication1.Properties.Settings.Default.Password);
            client.EnableSsl = true;

            client.Send(mail);
        }
    }
}
