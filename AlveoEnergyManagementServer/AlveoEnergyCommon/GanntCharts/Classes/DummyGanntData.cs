using AlveoEnergyCommon.GanntCharts.Interface;
using System;

namespace AlveoEnergyCommon.GanntCharts.Classes
{
    public class DummyGanntData : IDummyGanntData
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
