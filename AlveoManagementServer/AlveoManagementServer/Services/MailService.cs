using AlveoManagementCommon.Classes;
using AlveoManagementServer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;

namespace AlveoManagementServer.Services
{
    
    public class MailService
    {

        public SendMail()
        {
            var mailMessage = new MimeMessage();

            mailMessage.From.Add(new MailboxAddress("from name", "from email"));
            mailMessage.To.Add(new MailboxAddress("to name", "to email"));
            mailMessage.Subject = "subject";
            mailMessage.Body = new TextPart("plain")
            {
                Text = "Hello"
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 587, true);
                smtpClient.Authenticate("user", "password");
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }
    }
}
