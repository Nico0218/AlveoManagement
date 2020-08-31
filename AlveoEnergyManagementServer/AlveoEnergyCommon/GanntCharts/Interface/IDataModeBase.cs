using System;

namespace AlveoEnergyCommon.GanntCharts.Interface
{
    public interface IDataModeBase
    {
        string ID { get; set; }
        string Name { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
