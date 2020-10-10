using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes
{
    public class Item : IItem
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string PartNumber { get; set; }
        public int Qty { get; set; }
        public double Cost { get; set; }
        public int Instock { get; set; }
        public int Req { get; set; }
        public string Unit { get; set; }
        public string Category { get; set; }
    }
}
