using AlveoManagementCommon.Interfaces;
using System;
using System.Xml.Serialization;

namespace AlveoManagementCommon.Classes
{
    public class GanttLink : IGanttLink
    {
        public int ID { get; set; }
        public int Source { get; set; }
        public int Target { get; set; }
        public string Type { get; set; }

    }
}
