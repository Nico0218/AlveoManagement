using AlveoManagementCommon.Interfaces.Quote_Interfaces;
using System.Collections.Generic;

namespace AlveoManagementCommon.Classes {
    public class Quote : IQuote {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<Customer> customer { get; set; }
        public string orderNr { get; set; }
        public string projectName { get; set; }
        public string forAttention { get; set; }
        public string date { get; set; }
        public string quoteNumber { get; set; }
        public string validUntil { get; set; }
        //public List<Item> quoteItems { get; set; }
        public double subTotal { get; set; }
        public double taxRate { get; set; }
        public double taxDue { get; set; }
        public double otherCosts { get; set; }
        public double quoteTotal { get; set; }
        public string status { get; set; }
    }
}
