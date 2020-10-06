﻿using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class Personnel : IPersonnel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StartDate { get; set; }
        public string ContactNumber { get; set; }
    }
}
