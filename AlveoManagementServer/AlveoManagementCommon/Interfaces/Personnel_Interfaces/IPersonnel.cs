namespace AlveoManagementCommon.Interfaces
{
    public interface IPersonnel : IDataModelBase
    {
        string Surname { get; set; }

        string StartDate { get; set; }
        string ContactNumber { get; set; }
    }
}
