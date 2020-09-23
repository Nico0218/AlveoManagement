﻿using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class VsdItem : IVsdItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string PartNumber { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Req { get; set; }
        public int Rate { get; set; }
    }
}
