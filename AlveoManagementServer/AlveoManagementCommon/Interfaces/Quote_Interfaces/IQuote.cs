using System;
using AlveoManagementCommon.Classes;
using System.Collections.Generic;
using System.Text;

namespace AlveoManagementCommon.Interfaces.Quote_Interfaces
{
    interface IQuote
    {
        public List<Customer> customer { get; set; }
        public string orderNr { get; set; }
        public string projectName { get; set; }
        public string forAttention { get; set; }
        public DateTime date { get; set; }
        public string quoteNumber { get; set; }
        public DateTime validUntil { get; set; }
        public Array quoteItems { get; set; }
        public int subTotal { get; set; }
        public int taxRate { get; set; }
        public int taxDue { get; set; }
        public int otherCosts { get; set; }
        public int quoteTotal { get; set; }
        public List<Status> status { get; set; }
    }
}
