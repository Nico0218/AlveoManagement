using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class GanttLink : IGanttLink
    {
        public string id { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public string type { get; set; }        
    }
}
