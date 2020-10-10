using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class GanttData : IGanttData
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string text { get; set; }
        public int progress { get; set; }
        public int duration { get; set; }
        public int parent { get; set; }
        public string color { get; set; }
        public string gantttype { get; set; }
        public string personnel { get; set; }

    }
}
