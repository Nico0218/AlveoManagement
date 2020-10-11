﻿using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class Task : ITask
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Number { get; set; }
        public int Progress { get; set; }
        public int Duration { get; set; }
        public string Parent { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string Personnel { get; set; }
        public string Leader { get; set; }
    }
}
