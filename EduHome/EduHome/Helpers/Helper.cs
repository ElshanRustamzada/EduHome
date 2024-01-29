using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System;

namespace EduHome.Helpers
{
    public static class Helper
    {
        //public const string Admin = "Admin";
        //public const string Member = "Member";

        public static async Task SendMailAsync(string messageSubject, string messageBody, string mailTo)
        {
            SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("tural.j@itbrains.edu.az", "ahmiudsnaaadzneu");
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            MailMessage message = new MailMessage("tural.j@itbrains.edu.az", mailTo);
            message.Subject = messageSubject;
            message.Body = messageBody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            await client.SendMailAsync(message);

        }
    }
    enum Roles
    {
        Admin,
        Member
    }
}
