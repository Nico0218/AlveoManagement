using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes {
    public class GanttData : IGanttData {
        public string id { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string text { get; set; }
        public int progress { get; set; }
        public int duration { get; set; }
        public string parent { get; set; }
        public string color { get; set; }
        public string gantttype { get; set; }
        public string personnel { get; set; }
        public string ProjectLeader { get; set; }
        public string ProjectNumber { get; set; }

        public static explicit operator GanttData(Project source) {
            GanttData ganttData = new GanttData() {
                id = source.ID,
                text = source.Name,
                start_date = source.StartDate,
                end_date = source.EndDate,
                duration = source.Duration,
                progress = source.Progress,
                parent = source.Parent,
                color = source.Color,
                gantttype = source.Type,
                personnel = source.Personnel,
                ProjectLeader = source.Leader,
                ProjectNumber = source.Number
            };
            return ganttData;
        }

        public static explicit operator Project(GanttData source) {
            Project project = new Project() {
                ID = source.id,
                Name = source.text,
                StartDate = source.start_date,
                EndDate = source.end_date,
                Duration = source.duration,
                Progress = source.progress,
                Parent = source.parent,
                Color = source.color,
                Type = source.gantttype,
                Personnel = source.personnel,
                Leader = source.ProjectLeader,
                Number = source.ProjectNumber
            };
            return project;
        }

    }
}
