namespace AlveoManagementCommon.Interfaces
{
    //A common interface that will define basic properties that should be shared across all data models
    public interface IDataModelBase
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
