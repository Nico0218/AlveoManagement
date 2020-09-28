using System;

namespace AlveoManagementCommon.Interfaces.Personnel_Interfaces
{
    public interface IWarning
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public DateTime ncrdate { get; set; }
        public string details { get; set; }
        public string companyComments { get; set; }
        public string employeeComments { get; set; }
    }
}
