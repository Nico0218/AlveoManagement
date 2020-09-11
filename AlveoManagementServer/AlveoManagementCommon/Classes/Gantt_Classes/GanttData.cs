using AlveoManagementCommon.Interfaces;
using System;
using System.Xml.Serialization;

namespace AlveoManagementCommon.Classes
{
    public class GanttData : IGanttData
    {
        public int ID { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Text { get; set; }
        public int Progress { get; set; }
        public int Duration { get; set; }
        public int Parent { get; set; }
        public string Color { get; set; }
    }
}
