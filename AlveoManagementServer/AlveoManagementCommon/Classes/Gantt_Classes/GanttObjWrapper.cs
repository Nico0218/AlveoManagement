using System.Collections.Generic;

namespace AlveoManagementCommon.Classes {
    public class GanttObjWrapper {
        public GanttObjWrapper() {
            data = new List<GanttData>();
            links = new List<GanttLink>();
        }

        public List<GanttData> data { get; set; }

        public List<GanttLink> links { get; set; }
    }
}
