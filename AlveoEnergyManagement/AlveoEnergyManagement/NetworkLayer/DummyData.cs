using AlveoEnergyCommon.GanntCharts.Classes;
using System;

namespace AlveoEnergyManagement.NetworkLayer
{
    public class DummyData
    {
        public DummyGanntData GetSampleData()
        {
            return new DummyGanntData()
            {
                ID = Guid.NewGuid().ToString()
            };
        }


    }
}
