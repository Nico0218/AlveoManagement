namespace AlveoManagementCommon.Interfaces
{
    public interface IGanttLink
    {
        public string id { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }
}
