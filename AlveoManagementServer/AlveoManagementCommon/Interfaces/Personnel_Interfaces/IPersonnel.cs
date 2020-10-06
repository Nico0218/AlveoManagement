namespace AlveoManagementCommon.Interfaces
{
    public interface IPersonnel
    {
        int ID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }

        string StartDate { get; set; }
        string ContactNumber { get; set; }
    }
}
