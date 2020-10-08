using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementCommon.Interfaces
{
    public interface IInventoryItems
    {
        public List<Item> Automation
        {
            get;
            set;
        }
        public List<Item> Cabletrays
        {
            get;
            set;
        }
        public List<Item> Extras
        {
            get;
            set;
        }
        public List<Item> Instrumentation
        {
            get;
            set;
        }

        public List<Item> Labour
        {
            get;
            set;
        }

        public List<Item> Other
        {
            get;
            set;
        }

        public List<Item> Monitoring
        {
            get;
            set;
        }

        public List<Item> Switchgear
        {
            get;
            set;
        }
    }
}
