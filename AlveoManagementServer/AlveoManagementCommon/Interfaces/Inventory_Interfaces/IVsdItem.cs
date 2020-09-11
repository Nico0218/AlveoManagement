namespace AlveoManagementCommon.Interfaces
{
    public interface IVsdItem : IModeBase
    {
        string Make { get; set; }
        string PartNumber { get; set; }
        int Qty { get; set; }
    }
}
