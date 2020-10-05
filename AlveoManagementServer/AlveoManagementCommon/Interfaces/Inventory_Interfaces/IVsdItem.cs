namespace AlveoManagementCommon.Interfaces
{
    public interface IVsdItem : IModeBase
    {
        string Make { get; set; }
        string PartNumber { get; set; }
        int Qty { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Req { get; set; }
        public double Rate { get; set; }
    }
}
