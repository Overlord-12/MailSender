using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Smtp
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {

            string json = File.ReadAllText("configure.json");
            Credential myDeserializedClass = JsonConvert.DeserializeObject<Credential>(json);
            string emailSender = myDeserializedClass.Email;
            string password = myDeserializedClass.Password;

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", emailSender));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 25, false);
                await client.AuthenticateAsync(emailSender, password);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
