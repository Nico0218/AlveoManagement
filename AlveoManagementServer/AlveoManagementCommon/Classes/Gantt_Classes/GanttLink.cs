using AlveoManagementCommon.Interfaces;
using System;
using System.Xml.Serialization;

namespace AlveoManagementCommon.Classes
{
    public class GanttLink : IGanttLink
    {
        public int id { get; set; }
        public int source { get; set; }
        public int target { get; set; }
        public string type { get; set; }

    }
}
