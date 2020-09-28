using System.Collections.Generic;

namespace AlveoManagementCommon.Classes
{
    public class GanttObjWrapper
    {
        public List<GanttData> data
        {
            get;
            set;
        }
        public List<GanttLink> links
        {
            get;
            set;
        }
    }
}
