using Online_Learning_Platform.Models;
using System.Net;
using System.Net.Mail;

namespace Online_Learning_Platform.Helpers
{
    public static class EmailSetting
    {
        public static void SendEmail(Email email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential("ahmedkamel120012@gmail.com", "gvps sdjn rioo mkfr");
			smtpClient.EnableSsl = true;  // Enable SSL if needed
			smtpClient.Send("ahmedkamel120012@gmail.com",email.To,email.Subject,email.Body);
        }
    }
}
