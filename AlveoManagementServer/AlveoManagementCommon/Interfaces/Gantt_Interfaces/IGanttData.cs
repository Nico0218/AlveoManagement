namespace AlveoManagementCommon.Interfaces
{
    public interface IGanttData
    {
        public int id { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string text { get; set; }
        public int progress { get; set; }
        public int duration { get; set; }
        public int parent { get; set; }
        public string color { get; set; }
    }
}
