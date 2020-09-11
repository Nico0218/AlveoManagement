namespace AlveoManagementCommon.Interfaces
{
    public interface IGanttLink
    {
        public int ID { get; set; }
        public int Source { get; set; }
        public int Target { get; set; }
        public string Type { get; set; }
    }
}
