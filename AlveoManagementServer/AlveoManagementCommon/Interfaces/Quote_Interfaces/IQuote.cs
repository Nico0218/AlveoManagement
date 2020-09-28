using AlveoManagementCommon.Classes;
using System;
using System.Collections.Generic;

namespace AlveoManagementCommon.Interfaces.Quote_Interfaces
{
    interface IQuote
    {
        public List<Customer> customer { get; set; }
        public string orderNr { get; set; }
        public string projectName { get; set; }
        public string forAttention { get; set; }
        public string date { get; set; }
        public string quoteNumber { get; set; }
        public string validUntil { get; set; }
        public Array quoteItems { get; set; }
        public int subTotal { get; set; }
        public int taxRate { get; set; }
        public int taxDue { get; set; }
        public int otherCosts { get; set; }
        public int quoteTotal { get; set; }
        public string status { get; set; }
    }
}
