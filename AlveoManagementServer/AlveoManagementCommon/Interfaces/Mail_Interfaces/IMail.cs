using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace AlveoManagementCommon.Interfaces
{
    public interface IMail
    {
        public MailAddress From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
    }
}
