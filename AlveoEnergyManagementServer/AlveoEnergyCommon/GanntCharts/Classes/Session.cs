using AlveoEnergyCommon.GanntCharts.Interface;
using System;

namespace AlveoEnergyCommon.GanntCharts.Classes
{
    public class Session : ISession
    {
        public string Token { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
