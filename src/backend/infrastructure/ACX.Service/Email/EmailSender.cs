using ACX.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ACX.Service.Email
{
    public class EmailSender:IEmailSender
    {
        private readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var Email = _configuration.GetSection("Email")["user"];
            var password = Environment.GetEnvironmentVariable("PASS");
            var client = new SmtpClient("smtp.office365.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("verify.autocarexpress@outlook.com", "Junejuly2023")
            };

            return client.SendMailAsync(
                new MailMessage(from: "verify.autocarexpress@outlook.com",
                                to: email,
                                subject,
                                message
                                ));
        }
    }
}
