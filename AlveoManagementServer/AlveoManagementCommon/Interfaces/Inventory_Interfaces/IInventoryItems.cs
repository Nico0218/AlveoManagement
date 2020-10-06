using AlveoManagementCommon.Classes;
using System.Collections.Generic;

namespace AlveoManagementCommon.Interfaces
{
    public interface IInventoryItems
    {
        public List<Item> Hmis
        {
            get;
            set;
        }
        public List<Item> Plcs
        {
            get;
            set;
        }
        public List<Item> Vsds
        {
            get;
            set;
        }
        public List<Item> Relays
        {
            get;
            set;
        }

        public List<Item> Contactors
        {
            get;
            set;
        }

        public List<Item> Isolators
        {
            get;
            set;
        }
    }
}
