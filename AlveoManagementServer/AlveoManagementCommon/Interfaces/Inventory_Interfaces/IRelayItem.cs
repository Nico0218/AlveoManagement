namespace AlveoManagementCommon.Interfaces
{
    public interface IRelayItem : IModeBase
    {
        string Make { get; set; }
        string PartNumber { get; set; }
        int Qty { get; set; }
        public double Rate { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Req { get; set; }
    }
}