namespace AlveoManagementCommon.Interfaces
{
    public interface IProject : IDataModelBase
    {
        public string StartDate { get; set; }
        public int Duration { get; set; }
        public string EndDate { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectLeader { get; set; }
    }
}
