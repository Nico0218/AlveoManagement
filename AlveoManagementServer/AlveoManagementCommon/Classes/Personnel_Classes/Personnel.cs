using AlveoManagementCommon.Interfaces;

namespace AlveoManagementCommon.Classes {
    public class Personnel : IPersonnel {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StartDate { get; set; }
        public string ContactNumber { get; set; }
        public string JobDescription { get; set; } = "VloerBoy";
        public string Color { get; set; } = "blue";

        public string GetFullName() {
            return $"{Name} {Surname}";
        }
    }
}
