namespace AlveoManagementCommon.Interfaces
{
    public interface IGanttLink
    {
        public int id { get; set; }
        public int source { get; set; }
        public int target { get; set; }
        public string type { get; set; }
    }
}
