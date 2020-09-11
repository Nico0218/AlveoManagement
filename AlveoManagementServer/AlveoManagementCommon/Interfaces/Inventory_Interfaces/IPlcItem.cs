namespace AlveoManagementCommon.Interfaces
{
    public interface IPlcItem : IModeBase
    {
        string Make { get; set; }
        string PartNumber { get; set; }
        int Qty { get; set; }
    }
}
