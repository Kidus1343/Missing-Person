
using System.Net;
using System.Net.Mail;

namespace Project_01
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {


            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("decekikuul@gmail.com", "password")
            };

            return client.SendMailAsync(
                new MailMessage(from: "decekikuul@gmail.com",
                                to: email,
                                subject,
                                message
                                ));
        }
    }
}
