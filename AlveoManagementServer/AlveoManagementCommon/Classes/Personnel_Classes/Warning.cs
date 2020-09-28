using Microsoft.VisualBasic;

namespace AlveoManagementCommon.Classes.Personnel_Classes
{
    public class Warning
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public DateAndTime ncrDate { get; set; }
        public string details { get; set; }
        public string companyCmments { get; set; }
        public string employeeComments { get; set; }
        public bool final { get; set; }

    }
}
