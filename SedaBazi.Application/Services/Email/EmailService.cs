using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SedaBazi.Application.Services.Email
{
    public class EmailService : IEmailService
    {
        public Task Execute(string email, string subject, string body)
        {
            var client = CreateSmtpClient();
            var message = CreateMailMessage(email, subject, body);

            client.Send(message);

            return Task.CompletedTask;
        }

        private static MailMessage CreateMailMessage(string userEmail, string subject, string body) =>
            new("sedabazi2021@gmail.com", userEmail, subject, body)
            {
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess
            };

        private static SmtpClient CreateSmtpClient() =>
            new()
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Timeout = 100_000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("sedabazi2021@gmail.com", "amshAMSH2021")
            };
    }
}
