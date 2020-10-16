namespace AlveoManagementCommon.Interfaces
{
    public interface ICustomer: IDataModelBase
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string OrderNumber { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
        public string ContactNumber { get; set; }
        public string CustomerID { get; set; }
    }
}
