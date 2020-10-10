namespace AlveoManagementCommon.Interfaces
{
    public interface IGanttLink : IDataModelBase
    {
        public int source { get; set; }
        public int target { get; set; }
        public string type { get; set; }
    }
}
