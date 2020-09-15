using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes.Customer_Classes
{
    public class Customer : ICustomer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string addrLine1 { get; set; }
        public string addrLine2 { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string orderNumber { get; set; }
        public string project { get; set; }
        public string contactNumber { get; set; }
        public string taxNumber { get; set; }
    }
}
