namespace AlveoManagementCommon.Interfaces
{
    public interface IHmiItem : IModeBase
    {
        string Make { get; set; }
        string PartNumber { get; set; }
        int Qty { get; set; }
    }
}
