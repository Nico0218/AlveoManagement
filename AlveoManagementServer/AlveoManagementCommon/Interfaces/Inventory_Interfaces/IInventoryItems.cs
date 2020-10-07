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

        public List<Item> Brackets
        {
            get;
            set;
        }

        public List<Item> Distribution
        {
            get;
            set;
        }

        public List<Item> Ethernet
        {
            get;
            set;
        }

        public List<Item> Fans
        {
            get;
            set;
        }

        public List<Item> Flowmeters
        {
            get;
            set;
        }

        public List<Item> Fuseholders
        {
            get;
            set;
        }

        public List<Item> Misc
        {
            get;
            set;
        }

        public List<Item> Plcaux
        {
            get;
            set;
        }

        public List<Item> Psu
        {
            get;
            set;
        }

        public List<Item> Panels
        {
            get;
            set;
        }

        public List<Item> Plugs
        {
            get;
            set;
        }

        public List<Item> Power
        {
            get;
            set;
        }

        public List<Item> Sensors
        {
            get;
            set;
        }

        public List<Item> Starters
        {
            get;
            set;
        }

        public List<Item> Surge
        {
            get;
            set;
        }

        public List<Item> Switchgear
        {
            get;
            set;
        }

        public List<Item> Transformers
        {
            get;
            set;
        }

        public List<Item> Ups
        {
            get;
            set;
        }

        public List<Item> Vsdaux
        {
            get;
            set;
        }
    }
}
