using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class Item : IItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string PartNumber { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Req { get; set; }
    }
}
