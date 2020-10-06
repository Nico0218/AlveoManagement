using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class Project : IProject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public int Duration { get; set; }
        public string EndDate { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectLeader { get; set; }
    }
}
