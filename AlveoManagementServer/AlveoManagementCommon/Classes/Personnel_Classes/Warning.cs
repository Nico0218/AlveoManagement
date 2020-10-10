using AlveoManagementCommon.Interfaces.Personnel_Interfaces;
using System;

namespace AlveoManagementCommon.Classes
{
    public class Warning : IWarning
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime ncrdate { get; set; }
        public string details { get; set; }
        public string companyCmments { get; set; }
        public string employeeComments { get; set; }
        public bool final { get; set; }
        public string companyComments { get; set; }
    }
}
