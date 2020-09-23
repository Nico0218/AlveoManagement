using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementCommon.Interfaces
{
    public interface IInventoryItems
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
    }
}
