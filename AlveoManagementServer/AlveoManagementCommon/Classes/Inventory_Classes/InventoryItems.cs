using AlveoManagementCommon.Interfaces;
using System.Collections.Generic;

namespace AlveoManagementCommon.Classes
{
    public class InventoryItems : IInventoryItems
    {
        public List<HmiItem> Hmis
        {
            get;
            set;
        }
        public List<PlcItem> Plcs
        {
            get;
            set;
        }
        public List<VsdItem> Vsds
        {
            get;
            set;
        }
        public List<RelayItem> Relays
        {
            get;
            set;
        }
    }
}
