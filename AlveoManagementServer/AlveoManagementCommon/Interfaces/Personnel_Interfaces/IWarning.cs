using System;

namespace AlveoManagementCommon.Interfaces.Personnel_Interfaces
{
    public interface IWarning : IDataModelBase
    {
        public string LastName { get; set; }
        public DateTime ncrdate { get; set; }
        public string details { get; set; }
        public string companyComments { get; set; }
        public string employeeComments { get; set; }
    }
}
