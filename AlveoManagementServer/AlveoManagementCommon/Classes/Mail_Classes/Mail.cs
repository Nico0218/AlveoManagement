using AlveoManagementCommon.Interfaces;
using System.Net.Mail;

namespace AlveoManagementCommon.Classes
{
    public class Mail : IMail
    {
        public MailAddress From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
    }
}


//var mailMessage = new MimeMessage();
//mailMessage.From.Add(new MailboxAddress("from name", "from email"));
//mailMessage.To.Add(new MailboxAddress("to name", "to email"));
//mailMessage.Subject = "subject";
//mailMessage.Body = new TextPart("plain")
//{
//    Text = "Hello"
//};

//using (var smtpClient = new SmtpClient())
//{
//    smtpClient.Connect("smtp.gmail.com", 587, true);
//    smtpClient.Authenticate("user", "password");
//    smtpClient.Send(mailMessage);
//    smtpClient.Disconnect(true);
//}