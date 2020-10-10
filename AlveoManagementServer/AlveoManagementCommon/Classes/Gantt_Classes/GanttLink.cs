using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class GanttLink : IGanttLink
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int source { get; set; }
        public int target { get; set; }
        public string type { get; set; }        
    }
}
