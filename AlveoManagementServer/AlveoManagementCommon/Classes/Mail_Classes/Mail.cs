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
